namespace Hotelogram
{
    /// <summary>
    /// Defines static access to the <see cref="System.Windows.Forms.Form"/>s used in the project.
    /// </summary>
    public class FormHelper
    {
        //Add, edit, view, remove dialogs
        private static DAbout _dAbout;
        private static DAddAction _dAddAction;
        private static DAddEmployee _dAddEmployee;
        private static DAddFurniture _dAddFurniture;
        private static DAddGuest _dAddGuest;
        private static DAddRoom _dAddRoom;
        private static DBillInfo _dBillInfo;
        private static DGuestCheckout _dGuestCheckout;
        private static DViewReports _dViewReports;

        //Login dialog
        private static DLogin _dLogin;

        //Forms
        private static FMainMenu _fMainMenu; 
        private static FGuests _fGuests;
        private static FEmployees _fEmployees;
        //private static FQueryDatabase _fQueryDatabase;
        private static FRooms _fRooms;

        public static DAbout DAbout
        {
            get => _dAbout ?? (_dAbout = new DAbout());
            set => _dAbout = value;
        }

        public static DAddAction DAddAction
        {
            get => _dAddAction ?? (_dAddAction = new DAddAction());
            set => _dAddAction = value;
        }

        public static DAddEmployee DAddEmployee
        {
            get => _dAddEmployee ?? (_dAddEmployee = new DAddEmployee());
            set => _dAddEmployee = value;
        }

        public static DAddFurniture DAddFurniture
        {
            get => _dAddFurniture ?? (_dAddFurniture = new DAddFurniture());
            set => _dAddFurniture = value;
        }

        public static DAddGuest DAddGuest
        {
            get => _dAddGuest ?? (_dAddGuest = new DAddGuest());
            set => _dAddGuest = value;
        }

        public static DAddRoom DAddRoom
        {
            get => _dAddRoom ?? (_dAddRoom = new DAddRoom());
            set => _dAddRoom = value;
        }

        public static DBillInfo DBillInfo
        {
            get => _dBillInfo ?? (_dBillInfo = new DBillInfo());
            set => _dBillInfo = value;
        }

        public static DGuestCheckout DGuestCheckout
        {
            get => _dGuestCheckout ?? (_dGuestCheckout = new DGuestCheckout());
            set => _dGuestCheckout = value;
        }

        public static DViewReports DViewReports
        {
            get => _dViewReports ?? (_dViewReports = new DViewReports());
            set => _dViewReports = value;
        }

        public static DLogin DLogin => _dLogin ?? (_dLogin = new DLogin());

        public static FMainMenu FMainMenu
        {
            get => _fMainMenu ?? (_fMainMenu = new FMainMenu());
            set => _fMainMenu = value;
        }

        public static FGuests FGuests
        {
            get => _fGuests ?? (_fGuests = new FGuests());
            set => _fGuests = value;
        }

        public static FEmployees FEmployees
        {
            get => _fEmployees ?? (_fEmployees = new FEmployees());
            set => _fEmployees = value;
        }

        //public static FQueryDatabase FQueryDatabase { get; set; } = new FQueryDatabase();

        public static FRooms FRooms
        {
            get => _fRooms ?? (_fRooms = new FRooms());
            set => _fRooms = value;
        }
    }
}