using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace KBR.Utility
{
    public static class EnumExtensions
    {
        // This method creates a specific call to the above method, requesting the
        // Description MetaData attribute.
        public static string GetDisplayName(this Enum value)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(false);
            if (attributes.Length > 0)
                return ((DisplayAttribute)(attributes[0])).Name;
            else
                return value.ToString();
        }

        public static string GetConstStr(this Enum enumValue)
        {
            if (enumValue != null)
            {
                MemberInfo[] mi = enumValue.GetType().GetMember(enumValue.ToString());
                if (mi != null && mi.Length > 0)
                {
                    ConstStrAttribute attr = Attribute.GetCustomAttribute(mi[0], typeof(ConstStrAttribute)) as ConstStrAttribute;
                    if (attr != null)
                    {
                        return attr.Value;
                    }
                }
            }
            return null;
        }

        public static T GetEnumValueFromConstStr<T>(string constStr)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attr = Attribute.GetCustomAttribute(field, typeof(ConstStrAttribute)) as ConstStrAttribute;
                if (attr != null)
                {
                    if (attr.Value.ToUpper() == constStr.ToUpper())
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name.ToUpper() == constStr.ToUpper())
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "constStr");
            //return default(T);
        }

        public static string GetEnumNameByDisplayName(Type enumType, string displayName)
        {
            var enumNames = Enum.GetNames(enumType);

            foreach (var name in enumNames)
            {
                var memberInfo = enumType.GetMember(name);
                var attributes = memberInfo[0].GetCustomAttributes(false);

                if (attributes.Length > 0)
                {
                    if (((DisplayAttribute)(attributes[0])).Name.Equals(displayName, StringComparison.OrdinalIgnoreCase))
                    {
                        return name;
                    }
                }
            }

            return string.Empty;
        }

        public static IDictionary<int, string> ConvertEnumToDictionary(Type enumType)
        {
            var dictionary = new Dictionary<int, string>();

            var enumNames = Enum.GetNames(enumType);
            string enumDisplayName;

            foreach (var name in enumNames)
            {
                var memberInfo = enumType.GetMember(name);
                var attributes = memberInfo[0].GetCustomAttributes(typeof(DisplayAttribute),false);

                if (attributes.Length > 0)
                {
                    enumDisplayName = ((DisplayAttribute)(attributes[0])).Name;
                }
                else
                {
                    enumDisplayName = name;
                }

                dictionary.Add(Convert.ToInt32(Enum.Parse(enumType, name)), enumDisplayName);
            }

            return dictionary;
        }
    }

    public interface IAttribute<T>
    {
        T Value { get; }
    }

    public sealed class ConstStrAttribute : Attribute, IAttribute<string>
    {
        private readonly string value;

        public ConstStrAttribute(string value)
        {
            this.value = value;
        }

        public string Value
        {
            get { return this.value; }
        }
    }
}