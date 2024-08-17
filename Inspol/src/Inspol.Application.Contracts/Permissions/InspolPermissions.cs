namespace Inspol.Permissions;

public static class InspolPermissions
{
    public const string GroupName = "Inspol";



    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class Agents
    {
        public const string Default = GroupName + ".Agents";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
