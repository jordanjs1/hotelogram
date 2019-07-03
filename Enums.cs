using System;

namespace Hotelogram
{
    [Flags]
    public enum UserPermission
    {
        None = 0,
        View = 1,
        Add = 2,
        Edit = 4,
        Remove = 8,
        QueryDatabase = 16,
        All = ~None
    }

    [Flags]
    public enum GuestPermission
    {
        None = 0,
        View = 1,
        Reserve = 2,
        Register = 4,
        Edit = 8,
        Remove = 16,
        ViewGuestBill = 32,
        EditGuestBill = 64,
        AcceptFeedback = 128,
        All = ~None
    }

    [Flags]
    public enum RoomPermission
    {
        None = 0,
        View = 1,
        Add = 2,
        Edit = 4,
        Remove = 8,
        All = ~None
    }

    [Flags]
    public enum EmployeePermission
    {
        None = 0,
        View = 1,
        Add = 2,
        Edit = 4,
        Remove = 8,
        ViewReports = 16,
        AddReport = 32,
        RemoveReport = 64,
        All = ~None
    }

    [Flags]
    public enum InventoryPermission
    {
        None = 0,
        View = 1,
        Add = 2,
        Edit = 4,
        Remove = 8,
        All = ~None
    }
}
