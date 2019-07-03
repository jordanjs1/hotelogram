namespace Hotelogram
{
    public class PermissionInfo
    {
        public UserPermission UserPermissions { get; set; }
        public GuestPermission GuestPermissions { get; set; }
        public RoomPermission RoomPermissions { get; set; }
        public EmployeePermission EmployeePermissions { get; set; }
        public InventoryPermission InventoryPermissions { get; set; }
    }
}
