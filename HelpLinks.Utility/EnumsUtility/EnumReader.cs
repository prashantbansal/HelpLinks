using HelpLinks.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HelpLinks.Utility.EnumsUtility
{
    public static class EnumReader
    {
        //public IList<string> ReadEnumFile()
        //{
        //    IList<string> enumList = new List<string>();

        //    string enumFilePath = "";

        //    var allLines = File.ReadAllLines(enumFilePath);

        //    foreach (var line in allLines)
        //    {
        //        if (line.Trim().StartsWith("public enum "))
        //        {
        //            enumList.Add(line.Trim().Replace("public enum ", string.Empty).Trim());
        //        }
        //    }

        //    return enumList;
        //}

        public static IList<EnumClass> GetAllEnumNames()
        {
            var allEnumTypes = GetEnumTypeList();

            return allEnumTypes.Select(row => new EnumClass() {EnumName = row.Name}).ToList();
        }

        public static IList<EnumClass> GetEnumDetails(string enumName)
        {
            IList<EnumClass> enumClassList = new List<EnumClass>();

            Type type = GetEnumType(enumName);

            EnumClass enumClass = new EnumClass {EnumName = enumName};

            foreach (var value in Enum.GetValues(type))
            {
                enumClass.EnumFields.Add(new EnumField()
                {
                    EnumValue = (int) value,
                    EnumText = value.ToString()

                });
            }

            enumClassList.Add(enumClass);

            return enumClassList;
        }

        public static IList<EnumClass> GetAllEnumDetailsList()
        {
            var allEnumsTypeList = GetEnumTypeList();

            IList<EnumClass> allEnumsDetailList = new List<EnumClass>();

            foreach (var type in allEnumsTypeList)
            {
                var enumClass = new EnumClass() {EnumName = type.Name};

                foreach (var value in Enum.GetValues(type))
                {
                    enumClass.EnumFields.Add(new EnumField()
                    {
                        EnumValue = Convert.ToInt32(value),
                        EnumText = value.ToString()

                    });
                }

                allEnumsDetailList.Add(enumClass);
            }
            return allEnumsDetailList;
        }

        private static IEnumerable<Type> GetEnumTypeList()
        {
            var results = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsEnum && t.IsPublic);

            return results.ToList();
        }

        private static Type GetEnumType(string enumName)
        {
            var results = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsEnum && t.IsPublic && t.Name.Equals(enumName));

            return results.FirstOrDefault();
        }
    }
}
