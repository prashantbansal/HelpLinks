using KBR.Utility;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace KBR.Entity.Enums
{
    public enum DataAvailability
    {
        [Display(Name = "Adequate data present")]
        Adequate_data_present = 0,
        [Display(Name = "No data available")]
        No_data_available = 1,
        [Display(Name = "Limited data available")]
        Limitted_data_available = 2,
        [Display(Name = "")]
        Not_Selected = -1
    }

    public enum UserRoles
    {
        [Display(Name = "All")]
        AllRoles = -2,
        [Display(Name = "Anonymous")]
        Anonymous = -1,
        [Display(Name = "Student")]
        Student = 1,
        [Display(Name = "None")]
        None = 0,
        [Display(Name = "Demo User Student")]
        DemoUserStudent = 2,
        [Display(Name = "ASP")]
        ASP = 3,
        [Display(Name = "ARC Infilaw")]
        ARCInfiLawStaff = 4,
        [Display(Name = "Grader")]
        EssayGrader = 11,
        [Display(Name = "Grader Manager")]
        GraderManager = 12,
        [Display(Name = "Local Admin")]
        LocalAdmin = 21,
        [Display(Name = "Academic Admin")]
        AcademicAdmin = 22,
        [Display(Name = "Super Admin")]
        SuperAdmin = 25,
        [Display(Name = "Grader Super Admin")]
        GraderSuperAdmin = 28,
        [Display(Name = "Institutional Dashboard User")]
        InstitutionalDashboardUser = 29
    }

    public enum Tabs
    {
        Quarantined = 0,
        EssayQueue,
        Graders,
        Pods,
        ContactInfo,
        MyEssays,
        StudentPerformance,
        IRACTable
    }

    public enum SortOrder
    {
        A,
        D
    }

    public enum QuarantineType
    {
        Reassign = 0,
        ContentError = 1,
        AnswerMissing = 2
    }

    //public enum AnswerChoice
    //{
    //    A,
    //    B,
    //    C,
    //    D
    //}

    public enum PrintQuizMode
    {
        Timed = 0,
        Tutor,
        Review
    }

    public enum TopicLevel
    {
        None = 0,
        L1 = 1,
        L2 = 2,
        L3 = 3
    }

    public enum DayDuration
    {
        Morning = 0,
        Afternoon,
        Evening
    }

    public enum EssayScoreType
    {
        None = 0,
        Normal = 1,
        MPT = 2,
        ShortQuestion = 3
        //MainContentSA = 3,  //TX
        //SelfContentSA = 4  // VA 
    }

    public enum AssignmentLinkToTypes
    {
        None = 0,
        URL = 1,
        UploadFile = 2,
        Amazon = 3
    }

    /// <summary>
    /// Enumeration for FSPAssignmentType
    /// </summary>
    public enum FSPAssignmentType
    {
        All = -1,
        Core = 0,
        Fundamental = 1,
        Practice = 2
    }

    /// <summary>
    /// 
    /// </summary>
    public enum FSPNumberOfHoursSelected
    {
        /// <summary>
        /// 
        /// </summary>
        Perday6hrs = 6,
        /// <summary>
        /// 
        /// </summary>
        Perday8hrs = 8,
        /// <summary>
        /// 
        /// </summary>
        Perday10hrs = 10,
        /// <summary>
        /// 
        /// </summary>
        Perday12hrs = 12
    }
    public enum VisibilityTypes
    {
        NeverShow = 0,
        AlwaysShow = 1,
        ShowBefore90days = 2,
        DefaultBundle = 3
    }

    public enum FSPTaskType
    {
        PT = 1, // Performance Test
        Essay = 2,
        MCQ = 3,
        MCQForEssay = 4,
        MCQ30minQuestion = 5
    }

    public enum ErrorStatus
    {
        None = 0,
        InvalidUserNameOrPassword = 1,
        AccountExpired = 2,
        AccountInactive = 3,
        AccountDeleted = 4,
    }

    //public enum SPESessionType
    //{
    //    Normal = 0,
    //    LastSessionOfTheDay = 1,
    //    Lunch = 2
    //}

    public enum Source
    {
        CourseUpdate = 1,
        Syllabus = 2,
        DiagnosticReport = 3
    }

    public enum PostingType
    {
        CourseMaterial = 1,
        DiagnosticReport = 2,
        AskAnExpert = 4
    }

    public enum CourseGroup
    {
        None = 0,
        BarReview = 1,
        LawSchool = 2,
    }

    /// <summary>
    /// Bundle Category enum.
    /// </summary>
    public enum BundleCategory
    {
        None = 0,
        BarReviewCourse = 1,
        LawSchoolStudents = 2,
        MPRE = 3,
        InstitutionalProgram = 4,
        ARC = 5,
        InfiLaw = 6,
        ARCInfiLaw = 7,
        BarReviewCourse_NonMBE = 8,
        Multistate = 9,
    }

    public enum UserSetting
    {
        EssaySubmissionPromptFor1LEssays = 1
    }

    //public enum SessionCategory
    //{
    //    OTI = 1,
    //    OD = 2
    //}

    public enum SessionType
    {
        [Display(Name = "Intro Message")]
        IntroMessage = 1,
        [Display(Name = "Quiz Section")]
        QuizSection = 2,
        [Display(Name = "Day Break")]
        BreakWithoutTime = 3,
        [Display(Name = "Break")]
        BreakWithTime = 4,
        [Display(Name = "End Message")]
        EndMessage = 5
    }

    [Serializable]
    public enum AttachmentCategory
    {
        [XmlEnum("-1")]
        NotApplicable = -1,
        [XmlEnum("1")]
        L1 = 1,
        [XmlEnum("2")]
        L2 = 2,
        [XmlEnum("3")]
        L3 = 3
    }

    public enum LawSchoolCategory
    {
        NoStudent = 1,
        AnonymousStudent = 2,
        Student = 3
    }

    public enum ViewASPDataOption
    {
        NoStudent = 1,
        AnonStudent = 2,
        Student = 3
    }

    public enum ControlType
    {
        Textbox = 1,
        Textarea = 2,
        Checkbox = 3,
        RTE = 4
    }

    public enum ConfigCategory
    {
        All = -2,
        ApplicationVariables = 1,
        IPHomePage = 2,
        IPDiagnostics = 3,
        EssayGrader = 4,
        CycleDetails = 5,
        QFormative = 6
    }

    public enum Platform
    {
        Web = 0,
        Mobile = 1,
    }

    public enum StaffListSort
    {
        Name,
        AliasId,
        Description
    }

    public enum GraderDashboard
    {
        [Display(Name = "Essays Graded")]
        EssaysGraded = 1,
        [Display(Name = "Estimated Earnings")]
        EstimatedEarnings = 2,
    }

    public enum GraderAdminDashboard
    {
        [Display(Name = "Essays Graded")]
        EssaysGraded = 1,
        [Display(Name = "Unassigned")]
        Unassigned = 2,
        [Display(Name = "Quarantined")]
        Quarantined = 3,
        [Display(Name = "In Progress")]
        InProgress = 4,
        [Display(Name = "Completed")]
        Completed = 5,
        [Display(Name = "Total")]
        Total = 6
    }

    public enum GraderSuperAdminDashboard
    {
        [Display(Name = "Essays Graded")]
        EssaysGraded = 1,
        [Display(Name = "Unassigned")]
        Unassigned = 2,
        [Display(Name = "Quarantined")]
        Quarantined = 3,
        [Display(Name = "In Progress")]
        InProgress = 4,
        [Display(Name = "Completed")]
        Completed = 5,
        [Display(Name = "Total")]
        Total = 6,
        [Display(Name = "Billed")]
        Billed = 7,
        [Display(Name = "UnBilled")]
        UnBilled = 8
    }

    public enum RecipientType
    {
        AllStudent,
        AllState,
        Allbundles,
        EnrollmentID,
        LawSchoolID,
        AllASP, //All Academic Support Personnel
        BundleCategory,
    }

    public enum CourseUpdateSortOrder
    {
        StartsOn,
        Title,
        Attachments,
        Recipient,
        Alias,
        ExpiresOn,
        UpdatedOn
    }

    public enum CompilationTable
    {
        Content,
        Compilation,
        Compilation_Content,
        Container_Content,
        AnswerOption
    }

    public enum AnswerOptionColumns
    {
        ContentID,
        IsCorrect,
        AnswerIndex,
        Text,
        AnswerOptionID
    }

    public enum ContentColumns
    {
        ContentID,
        ContentType,
        DifficultyLevel,
        Title,
        Stem,
        EssayRequirement,
        L3TopicID,
        KplanID,
        Explanation,
        TemplateUrl,
        ImgURL,
        MediaURL,
        EssayScoreType,
        MultiplicationFactor,
        FrequencyId
    }

    public enum CompilationColumns
    {
        CompilationId,
        Stem,
        Title,
        Reference,
        KaplanId
    }

    public enum CompilationContentColumns
    {
        CompilationId,
        ContentID,
        MapOrderId
    }

    public enum ContainerContentColumns
    {
        ContainerID,
        ContentID,
        PositionIndex,
        QuestionNumber,
        SPESessionID
    }

    public enum ParameterType
    {
        Insert,
        Update,
        Condition
    }

    public enum NodeActions
    {
        move = 1,
        copy = 2
    }

    public enum ControlMode
    {
        Add = 1,
        Edit = 2,
        View = 3
    }

    public enum ActionType
    {
        Create = 1,
        Edit = 2,
        View = 3
    }

    public enum ActionCommands
    {
        NA = 0,
        NewContent = 1,
        EditContent = 2,
        Preview = 3,
        View = 4,
        Review = 5,
        Repeat = 6,
        Resume = 7,
        ReviewIncorrect = 8,
        Suspend = 9,
        Submit = 10,
        NewTopic = 11,
        EditTopic = 12,
        Start = 13,
        CMS2Commands_Edit = 1000,
        EditAssignment_CMS = 1001,
        EditSession_CMS = 1002,
        EditCourse_CMS = 1003,
        EditState_CMS = 1004,
        CMS2Commands_New = 1500,
        NewAssignment_CMS = 1501,
        NewSession_CMS = 1502,
        NewCourse_CMS = 1503,
        NewState_CMS = 1504,
        Copy = 2001
    }

    public enum AnswerStatus
    {
        None = -2,
        Correct = 1,
        Finished = 5,
        Incorrect = 2,
        Read = 4,
        Omitted = 3,
        NotReached = -1,
        WaitingToBeGraded = 11,
        Grading = 12,
        Graded = 15,
        Quarantined = 16,
        KnowThis = 17,
        DontKnowThis = 18,
        MayBe = 19,
        OmittedAnswerSeen = 20,
        SelfReview = 21
    }

    public enum ContainerTypes
    {
        [Display(Name = "Early Study Plan")]
        EarlyStudyPlan = -4,
        [Display(Name = "Final Study Plan")]
        FinalStudyPlan = -3,
        [Display(Name = "All Types")]
        AllTypes = -2,
        [Display(Name = "Other")]
        Other = -1,
        [Display(Name = "Check Point Quiz")]
        CheckpointQuiz = 1,
        [Display(Name = "Practice Test")]
        PracticeTest = 2,
        [Display(Name = "Quizbank")]
        Quizbank = 3,
        [Display(Name = "Essay")]
        Essay = 4,
        [Display(Name = "Flashcard Quizbank")]
        FlashcardQuizbank = 5,
        [Display(Name = "Diagnostic Quiz")]
        DiagnosticQuiz = 6,
        [Display(Name = "Qbuilder Quiz")]
        QbuilderQuiz = 7,
        [Display(Name = "Feedback Quiz")]
        FeedbackQuiz = 8,
    }

    public enum ContainerMode
    {
        TimedQuiz = 1,
        TutorMode = 2
    }

    public enum ContentSubtypes
    {
        None = 0,
        MCQ_Motivational = 6
    }

    public enum AssignmentGroup
    {
        NA = -1,
        Quiz1 = 1,
        Quiz2 = 2,
        NextStep = 3,
        OneSheet = 4,
        BarNote = 5
    }

    public enum AssignmentFormats
    {
        [Display(Name = "AllTypes")]
        AllTypes = -2,
        [Display(Name = "Other")]
        Other = -1,
        [Display(Name = "None")]
        None = 0,
        [Display(Name = "Checkpoint Quiz")]
        CheckpointQuiz = 1,
        [Display(Name = "Practice Test")]
        PracticeTest = 2,
        [Display(Name = "QBank")]
        Quizbank = 3,
        [Display(Name = "Essay")]
        Essay = 4,
        [Display(Name = "Diagnostic")]
        DiagnosticQuiz = 6,
        [Display(Name = "Flex Flashcard")]
        Flashcard = 7,
        [Display(Name = "Workbook")]
        Reading = 101,
        [Display(Name = "Video")]
        Video = 102,
        [Display(Name = "Miscellaneous")]
        Miscellaneous = 103,
        [Display(Name = "Notes")]
        Notes = 104,
        [Display(Name = "Strength and Weakness Guide")]
        ReviewTopicInPSP = 201
    }

    //public enum AssignmentFormats
    //{
    //    AllTypes = -2,
    //    Other = -1,
    //    CheckpointQuiz = 1,
    //    PracticeTest = 2,
    //    Quizbank = 3,
    //    Essay = 4,
    //    DiagnosticQuiz = 6,
    //    Reading = 101,
    //    Video = 102,
    //    Miscellaneous = 103,
    //    Notes = 104,
    //    ReviewTopicInPSP = 201
    //}

    public enum ContentCopyModes
    {
        Html = 1,
        Text = 2
    }

    public enum ContentTypes
    {
        AllTypes = -2,
        Document = 11,
        Question_Essay = 3,
        Question_MultiAnswer = 2,
        Question_SingleSelect = 1,
        Question_Comprehension = 4,
        Video = 12,
        Question_Flashcard = 5
    }

    public enum DifficultyLevels
    {
        AllLevels = -2,
        Difficult = 3,
        Easy = 1,
        Medium = 2,
        NoLevel = -1
    }

    public enum DropDownListValues
    {
        All = -2,
        NotSelected = -1
    }

    public enum EssayIssueTypes
    {
        Header = 1,
        Issue = 2
    }

    public enum MoveActions
    {
        Down = 2,
        Down10 = 12,
        Up = 1,
        Up10 = 11
    }

    public enum MoveDirections
    {
        Down = 2,
        Up = 1
    }

    //public enum PSP_StepGroups
    //{
    //    Assignment = 1,
    //    Quiz1 = 1,
    //    Quiz2 = 2
    //}

    public enum QuestionReuseModes
    {
        All = 2,
        UnUsed = 1
    }

    public enum QuestionStatus
    {
        All = -2,
        Unused = 1
    }

    public enum RequirementLevels
    {
        NA = -1,
        Required = 1,
        Recommended = 2
    }

    public enum TemplateModes
    {
        Edit = 1,
        Preview = 2,
        Review = 0x15,
        View = 20,
        PurePreview = 25
    }

    public enum TestStyles
    {
        Timed = 1,
        Tutor = 2
    }

    public enum Syllabus_OrganizeBy
    {
        Session = 1,
        RequirementLevel = 2,
        CompletionStatus = 3,
        AssignmentName = 4,
        Topic = 5,
        Format = 6,
        Inactive = 7
    }

    public enum CompleteStatuses
    {
        Incomplete = 1,//not start yet.
        InProgress = 2,//suspended.
        Complete = 3,//completed.
        MasteryAcheived = 4
    }

    public enum SpecialAssignmentIDs
    {
        NA = -1,
        AdditionalPracticeTest = -2,
        EssaysInEssayBank = -3
    }

    //public enum EssayScoreType
    //{
    //    Normal = 1,
    //    MPT = 2,
    //    MainContentSA = 3,  //TX
    //    SelfContentSA = 4  // VA 
    //}

    public enum GradingQueueTypes
    {
        StateView = 1,
        TopicView = 2
    }

    public enum GraderManagerPlanningTypes
    {
        StateView = 1,
        TopicView = 2
    }




    public enum FileChangedTypes
    {
        New = 1,
        Changed = 2,
        Deleted = 5
    }

    public enum NodeTypes
    {
        NA = -1,
        Home = -5,
        State = 10,
        Course = 11,
        Session = 12,
        Assignment = 13,
        L1Topic = 101,
        L2Topic = 102,
        L3Topic = 103

    }

    public enum ClassDates
    {
        Yes_show = 1,
        Yes_Donot_show = 2,
        No = 0
    }

    public enum MEEIncludeModes
    {
        None = 0,
        StateTopic = 1,
        MEETopic = 2
    }

    public enum TopicTypes
    {
        MBE = 1,
        MBEQbank = 2,
        MEE = 3
    }

    public enum GradingPageMode
    {
        Normal,
        Review
    }

    public enum EssayMode
    {
        Review,
        Normal
    }

    public enum GraderCreationModes
    {
        CreateNew,
        EditExisting,
        None
    }

    public enum QBankHistoryType
    {
        Completed = 1,
        Suspended = 2
    }

    public enum CalendarMode
    {
        Daily = 1,
        Monthly = 2
    }

    public enum EssayFactAnalysis
    {
        FA1,
        FA2,
        FA3,
        FA4
    }

    public enum EssayWrittenCommunication
    {
        WC1,
        WC2,
        WC3,
        WC4,
        WC5,
        WC6,
        WC7
    }

    public enum ThumbnailSize
    {
        Small = 1,
        Medium = 2
    }


    public enum GradingStateType
    {
        IRAC = 0,
        ARAC = 1,
        CRAC = 2
    }

    public enum HideCode
    {
        HW = 1,
        SPE = 2,
        WS = 3,
        MISC = 4
    }

    public enum AssignmentModule
    {
        Normal = 0,
        FSP = 1,
        ESP = 2,
        CPQ = 3,
        FormativeQbank = 4
    }

    public enum AssignmentCycle
    {
        Normal = 0,
        Orientation = 1
    }

    public enum DisplayOption
    {
        Term = 1,
        Definition = 2
    }

    public enum RegisteredFrom
    {
        Kaptest = 0,
        Slingshot = 1
    }

    //public enum SPETestMessage
    //{
    //    Introduction = 1,
    //    Break = 2,
    //    BreakComplete = 3,
    //    BetweenDay = 4,
    //    EndOfSPETest = 5
    //}

    /// <summary>
    /// SHPVideos enum for various Video/Slide values
    /// </summary>
    public enum SHPVideos
    {
        OrientationGuideVideo = 1,
        OrientationGuideSlide = 2,
        CourseConsultantVideo = 3,
        CourseConsultantSlide = 4,
        StudyGuruVideo = 5,
        StudyGuruSlide = 6,
        ErrataDocument = 7,
        ExamBreakdownDocument = 8
    }

    /// <summary>
    /// DocumentCategory Enum for Video/Presentation
    /// </summary>
    public enum DocumentCategory
    {
        Video = 1,
        Presentation = 2,
        Document = 3
    }

    public enum StudentFeatures
    {
        None = 0,
        StudyPlan = 1,
        Syllabus = 2,
        SWG = 3,
        Attendance = 4,
        Practice = 5,
        Qbank1 = 6,
        Essaybank = 7,
        PerformanceTests = 8,
        AdditionalPracticeExam = 9,
        TrackProgress = 10,
        AskAnAttorney = 11,
        TestAnalysis = 12,
        Qbank2 = 13,
        AcademicSupport = 14,
        CourseUpdates = 15,
        CourseMaterials = 16,
        FlashcardQuizbank = 17,
        Home = 18,
        FormativeQBank = 19,
        QFormative = 20
    }

    public enum FeatureOptions
    {
        [Display(Name = "")]
        NotSelected = -1,
        [Display(Name = "Never show")]
        NeverShow = 0,
        [Display(Name = "Always show")]
        AlwaysShow = 1,
        [Display(Name = "90 days before exam")]
        Before90DaysOfExam = 2,
        [Display(Name = "Disable link before 90 days")]
        DisableLinkBefore90Days = 3,
        [Display(Name = "Disable page before 90 days")]
        DisablePageBefore90Days = 4,
    }

    public enum SHPModules
    {
        Introduction = 1,
        CourseAndUpdates = 2,
        DateCounter = 3,
        MBEMCQPerformance = 4,
        EssayGrading = 5,
        FlexPerformance = 6,
        DailyAssignments = 7,
        Engagement = 8,
        LiveSimulcast = 9,
        MeetYourGrader = 10,
        ProgressToDate = 11
    }
    public enum ReleaseCycle
    {
        Feb = 1,
        Jul = 2,
    }

    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public enum YearOfStudy
    {
        [Display(Name = "--Select--")]
        None = -1,
        [Display(Name = "1L")]
        L1 = 1,
        [Display(Name = "2L")]
        L2 = 2,
        [Display(Name = "3L")]
        L3 = 3,
        Done = 100
    }

    public enum LawSchoolType
    {
        General = 1,
        InfiLaw = 2,
        Valpo = 3
    }

    public enum Range
    {
        None = -1,
        Low = 0,
        Medium = 1,
        High = 2,
    }
    public enum CustomerSupportMessages
    {
        IPLawSchoolNotAvailable = 1,
        ARCInfilawIncorrectLawSchool = 2,
        AAECoachEmailUnsubscribed = 3,
        GBRTechSupport = 4,
        PMBRTechSupport = 5,
        MakerPrepTechSupport = 6
    }


    public enum InfilawDashboardScore
    {
        InfilawSyllabusEssayMessage = 1,
        Low = 1,
        Medium = 2,
        High = 3
    }

    public enum InfilawDashboard
    {
        Skill = 1,
        Subject = 2,
        Motivational = 3,
        Topic = 4
    }

    public enum InfilawReportType
    {
        None = -1,
        Summary = 1,
        Quiz = 2
    }

    public enum UserProfileStatus
    {
        All = -1,
        Inactive = 0,
        Active = 1,
        Deleted = 2
    }

    public enum IRACScoringScale
    {
        None = -1,
        IRAC_0_2 = 2,
        IRAC_0_4 = 4
    }

    public enum EmailType
    {
        None = -1,
        EmailEssayGraded = 1,
        EmailFSPEnabled = 2,
        EmailNewAccountCreated = 3,
        EmailForgotPassword = 4,
        EmailStudentSubmitQuestion = 5,

        EmailFSPExamAlert = 6,
        EmailWeeklyDigestReport = 7,

        EmailContactGraderAdmin = 8,
        EmailContactGraderSuperAdmin = 9,
        EmailAskAnAttorney = 10,
        EmailTrainerEssayPassed = 11,
        EmailWelcomeCertificationProcess = 12,
        EmailTrainerEssayFailed = 13,
        EmailGraderCertified = 14,
        EmailGraderFailed = 15,
        AAECoach = 16,
        LiveSimulcastHandraising = 17,
        EmailScriptUpdates = 18,
        EmailSchedulerJobs = 19,
        EmailEssayHandOffSettings = 20,
        EmailGenerics = 21,
    }

    public enum EmailStatus
    {
        Success = 1,
        Failed = 2,
        Disabled = 3,
    }

    public enum AuditCategory
    {
        PushtoLive = 1,
        AAECoachEmailer = 2,
        QuizReopen = 3,
        EssayGradingRollback = 4,
        ScriptUpdate = 5,
        StudentMigration = 6
    }

    public enum DownloadFrom
    {
        AmazonCloud = 1,
        Akamai = 2,
        Web = 3
    }

    public enum EssayScoreIndicativeEnum
    {
        [Display(Name = "")]
        None = -1,
        [Display(Name = "Demonstrates Fundamental Deficiency")]
        WellBelowTheStandard = 1,
        [Display(Name = "Does Not Demonstrate Competency")]
        BelowTheStandard = 2,
        [Display(Name = "Demonstrates Some Competency")]
        MeetsTheStandard = 3,
        [Display(Name = "Demonstrates Sufficient Competency")]
        ExceedsTheStandard = 4
    }

    public enum SyllabusItemType
    {
        SyllabusItem,
        SyllabusSubItem
    }

    public enum EssayAge
    {
        All = 0,
        Age_0_2 = 1,
        Age_3_4 = 2,
        Age_5_6 = 3,
        Age_7_All = 4
    }

    public enum TabAccess
    {
        NoAccess = 0,
        FullAccess = 1,
        DisabledLink = 3,
        DisabledPage = 4,
    }

    public enum StateSkillGroup
    {
        Skills = 1,
        WrittenCommunication = 2,
        FactAnalysis = 3
    }

    public enum CertificationStatus
    {
        [Display(Name = "Not Attempted")]
        NotAttempted = 1,
        [Display(Name = "Pending Review")]
        PendingReview = 2,
        Certified = 3,
        Failed = 4

    }

    public enum SchedulerIdentifier
    {
        None = 0,
        ComparativeData = 1,
        ReportingDatabase = 2,
        InfilawReports = 3,
        RedmineAPIIntegrator = 4,
        SchedulerGeneric = 5,
        LawSchoolUpdate = 6,
        AAECoach = 7,
        ClassInformationUpdate = 8,
        AttendanceUpdate = 9
    }

    public enum RunStatus
    {
        None = -1,
        InProgress = 0,
        Passed = 1,
        Failed = 2
    }

    public enum EssayFrequencyType
    {
        None = 0,
        LowFrequency = 1,
        HighFrequency = 2,
        EssayBank = 3,
        Diagnostic = 4,
        Memo = 5,
        SPE = 6,
        Brief = 7,
        Letter = 8,
        Other = 9
    }

    public enum ShortAnswerType
    {
        Message = 1,
        Question = 2
    }

    public enum RedirectedVia
    {
        [ConstStr("KBR")]
        KBR,
        [ConstStr("PMBR")]
        PMBR,
        [ConstStr("KBR")]
        Kaptest,
        [ConstStr("MakerPrep")]
        MakerPrep
    }

    public enum VideoPlayerVersion
    {
        None = -1,
        v0 = 0, //initial version
        v1 = 1, //version with file _v1.xml
        v2 = 2 //version using new JS video player
    }

    public enum VideoListType
    {
        [ConstStr("none")]
        None = 0,
        [ConstStr("seek")]
        seek = 1,
        [ConstStr("video")]
        video = 2,
        [ConstStr("videoSet")]
        videoSet = 3
    }

    public enum MobileContainerCategory
    {
        None = 0,
        Flashcard = 1,
        QBank1 = 2,
        Qbank2 = 3
    }

    public enum QuizReportTypes
    {
        MCQ = 1,
        Essay = 2
    }

    public enum MobileStatusCode
    {
        InvalidParameter = -1,
        UnknownException = -2,
        Saved = 1,
        NewerUpdatesExistOnServer = 2,
        AlreadySubmitted = 3,
        InvalidContainerType = 4
    }

    public enum InfilawReportTypeYearOfStudy
    {
        All = 1,
        CurrentYear = 2
    }

    public enum AgingReportSortProperty
    {
        SubmissionDate = 1,
        StudentName = 2,
        LawSchoolName = 3,
        StudentID = 4,
        Subject = 5,
        TimeInQueue = 6,
        EssayID = 7,
        BundleCode = 8
    }

    public enum QuizStatus
    {
        Start = 1,
        InProgress = 2,
        Complete = 3
    }

    public enum DataStatus : byte
    {
        [ConstStr("inactive")]
        [Display(Name = "InActive")]
        Inactive = 0,
        [ConstStr("active")]
        [Display(Name = "Active")]
        Active = 1,
        [ConstStr("deleted")]
        [Display(Name = "Deleted")]
        Deleted = 2,
        [ConstStr("done")]
        [Display(Name = "Done")]
        Done = 3,
        [ConstStr("completed")]
        [Display(Name = "Completed")]
        Completed = 4,
        [ConstStr("canceled")]
        [Display(Name = "Canceled")]
        Canceled = 5,
        [ConstStr("underway")]
        [Display(Name = "Underway")]
        Underway = 6,
    }

    public enum CourseType
    {
        [ConstStr("Complete Bar Review Online")]
        [Display(Name = "Complete Bar Review Online")]
        CompleteBarReviewOnline = 0,
        [ConstStr("Complete Bar Review (In class)")]
        [Display(Name = "Complete Bar Review (In class)")]
        CompleteBarReviewInClass = 1,
        [ConstStr("General Bar Review Online")]
        [Display(Name = "General Bar Review Online")]
        GeneralBarReviewOnline = 2,
        [ConstStr("General Bar Review (In class)")]
        [Display(Name = "General Bar Review (In class)")]
        GeneralBarReviewInClass = 3,
        [ConstStr("Multistate")]
        [Display(Name = "Multistate")]
        Multistate = 4
    }

    public enum AnnouncementLimitTo
    {
        All = 0,
        Today = 1
    }

    public enum ContainerSessionStatus
    {
        [ConstStr("none")]
        [Display(Name = "None")]
        None = 0,

        [ConstStr("completed")]
        [Display(Name = "Completed")]
        Completed = 1,

        [ConstStr("inProgress")]
        [Display(Name = "In-Progress")]
        InProgress = 2,

        [ConstStr("notStarted")]
        [Display(Name = "Not Started")]
        NotStarted = 3
    }
    public enum DeviceType : byte
    {
        None = 0,
        iOS = 1,
        Android = 2,
        Windows = 3
    }

    public enum PushNotificationStatus : byte
    {
        Queued = 1,
        Sent = 2,
        Failed = 3
    }
    public enum UserTypes
    {
        [Display(Name = "--Select--")]
        None = -1,
        [Display(Name = "Professor")]
        Professor = 1,
        [Display(Name = "Law School Admin")]
        LawSchoolAdmin = 2
    }

    public enum TimeLimit
    {
        [Display(Name = "1.8 minutes")]
        OnePointEightMins = 1,
        [Display(Name = "2.0 minutes")]
        TwoMins = 2,
        [Display(Name = "2.5 minutes")]
        TwoPointFiveMins = 3,
        [Display(Name = "Unlimited")]
        Unlimited = 4,
        [Display(Name = "Tutor Mode")]
        TutorMode = 5
    }

    public enum QbuilderOptions
    {
        [Display(Name = "None")]
        None = -1,
        [Display(Name = "Never Show")]
        NeverShow = 0,
        [Display(Name = "Always Show")]
        AlwaysShow = 1,
        [Display(Name = "Show After")]
        ShowAfter = 2,
    }

    public enum QbuilderQuizStatus
    {
        none = -1,
        Deleted = 0,
        Created = 1,
        Published = 2,
    }

    public enum InstitutionalSectionStatus
    {
        Active = 1,
        Completed = 2,
        Canceled = 3
    }

    public enum InstitutionalSemester
    {
        Summer = 1,
        Spring = 2,
        Fall = 3
    }

    public enum AnalyticsCategory
    {
        IP = 1,
        SimulcastVideoPlayer = 2,
        General = 3
    }

    public enum CourseCycle
    {
        [Display(Name = "None")]
        None = 0,
        [Display(Name = "Winter")]
        Winter = 1,
        [Display(Name = "Spring")]
        Spring = 2,
        [Display(Name = "Summer")]
        Summer = 3,
        [Display(Name = "Fall")]
        Fall = 4
    }

    public enum RatingScale
    {
        ScaleOfFive = 5,
        ScaleOfThree = 3,
        ScaleOfFour = 4,
        ScaleOfTen = 10,
    }

    public enum RatingCategory
    {
        None = -1,
        Grader = 1,
        Video = 2,
        LiveSimulcast = 3
    }

    public enum AssociationStatus
    {
        None = 0,
        Added = 1,
        MarkedForDeletion = 2
    }

    public enum EnableType
    {
        Disabled = 0,
        Enabled = 1
    }

    public enum InteractiveVideoQuizType
    {
        Generic = 1,
        Feedback = 2
    }
    public enum LiveAttendanceStatus
    {
        Open = 1,
        UpdatedInKBS = 2,
        AttendanceAlreadyUpdated = 3,
        Error = 4
    }

    public enum ValidationType
    {
        Notification = 1,
        Error = 2,
        NoError = 3,
        NoUpdate = 4
    }

    public enum StudentMigrationType
    {
        [Display(Name = "Qbank")]
        Qbank1 = 1,
        [Display(Name = "Qbank")]
        Qbank2 = 2,
        [Display(Name = "Flex")]
        Flex = 3
    }

    public enum StudentMigrationStatus
    {
        None = -1,
        Success = 1,
        Failed = 2
    }

    public enum IntegratorCommand
    {
        Register = 1,
        Login = 2
    }

    public enum CourseFilter
    {
        All = -1,
        PMBR = 1,
        NonPMBR = 2,
        MakerPrep = 3
    }

    public enum Via
    {
        IOS = 1,
        Android = 2,
        Web = 3
    }

    public enum ProductType
    {
        None = -1,
        KBR = 1,
        PMBR = 2,
        Reports = 3,
        MakerPrep = 4
    }
    public enum AttendanceVia
    {
        None = -1,
        Web = 1,
        iOS = 2,
        Android = 3
    }

    //public enum QuestionType
    //{
    //    [Display(Name = "CheckPoint Quiz")]
    //    CheckPointQuiz =1,
    //    [Display(Name = "Practice Test")]
    //    PracticeTest = 2,
    //    [Display(Name = "QuizBank")]
    //    QuizBank = 3,
    //    [Display(Name = "Essay")]
    //    Essay = 3,
    //    [Display(Name = "Flashcard QuizBank")]
    //    Flashcard = 4,
    //    [Display(Name = "Diagonostic Quiz")]
    //    DiagonosticQuiz = 5,
    //    [Display(Name = "FeedBack Quiz")]
    //    FeedBackQuiz = 6,

    //}
    public enum ContainerSubTypes
    {
        [Display(Name = "NA")]
        NA = -1,
        [Display(Name = "Midterm")]
        Midterm = 1,
        [Display(Name = "Final")]
        Final = 2,
        [Display(Name = "QFormative")]
        QFormative = 3,
        [Display(Name = "Simulated Practice Exam")]
        SPE = 4

    }
}
