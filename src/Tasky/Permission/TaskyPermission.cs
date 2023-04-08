namespace Tasky.Permissions
{
    public static class TaskyPermissions
    {
        public const string GroupName = "Tasky";

        public static class TaskyItem
        {
            public const string Default = GroupName + ".TaskyItem";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }
    }
}