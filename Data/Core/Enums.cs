namespace Data
{
    public enum UserType : byte
    {
        Admin = 1,
        Customer
    }

    public enum Gender : byte
    {
        Male = 1,
        Female = 2
    }

    public enum PolicyType : byte
    {
        Motor = 1,
        Medical,
        Property,
        Travel
    }
}
