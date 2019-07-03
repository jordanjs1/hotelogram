using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotelogram
{
    /// <summary>
    /// Defines bills of <see cref="Guest"/>s which have <see cref="Action"/>s, an amount.
    /// </summary>
    public class Bill
    {
        /// <summary>
        /// Defines actions of <see cref="Bill"/>s which have an description and amount.
        /// </summary>
        public class Action
        {
            #region Fields
            private static int _actionIDCounter = 1; //Automatic ID assigner counter.
            #endregion

            #region Properties

            /// <summary>
            /// Gets the action's ID.
            /// </summary>
            public int ActionID { get; }

            /// <summary>
            /// Gets or sets the description of the action.
            /// </summary>
            public string ActionDescription { get; set; }

            /// <summary>
            /// Gets or sets the amount registered on the action.
            /// </summary>
            public float Amount { get; set; }
            #endregion

            #region Constructors

            /// <summary>
            /// Creates an action.
            /// </summary>
            /// <param name="actionDescription">The description of the action.</param>
            /// <param name="amount">The amount registered on the action.</param>
            public Action(string actionDescription, float amount)
            {
                ActionID = _actionIDCounter;
                ActionDescription = actionDescription;
                Amount = amount;
                _actionIDCounter++;
            }
            #endregion

            #region Methods

            /// <summary>
            /// Searches the actions for the given ID.
            /// </summary>
            /// <param name="bill">The bill to be searched for the action.</param>
            /// <param name="id">The action ID to be searched.</param>
            /// <returns>Returns that action if an action's ID matches to the given ID, otherwise null.</returns>
            public static Action GetActionByID(Bill bill, int id)
            {
                return (from a in bill.AllActions where a.ActionID == id select a).FirstOrDefault();
            }
            #endregion
        }

        #region Fields
        private float _amount;  //The total amount registered on the bill.
        #endregion

        #region Properties

        public Guid ID { get; }

        /// <summary>
        /// Gets the total amount on bill.
        /// </summary>
        public float Amount
        {
            get => CalculateAmount();
            private set => _amount = value;
        }

        /// <summary>
        /// Gets the guest the bill is registered to.
        /// </summary>
        public Guest Owner { get; }

        /// <summary>
        /// Gets the list that holds all actions registered on the bill.
        /// </summary>
        public List<Action> AllActions { get; } = new List<Action>();
        #endregion

        #region Constructors

        /// <summary>
        /// Creates a bill.
        /// </summary>
        /// <param name="guest">The guest the bill will be registered to.</param>
        public Bill(Guest guest)
        {
            Owner = guest;
            ID = Guid.NewGuid();

            //Database.MakeGuestBillTriple(guest, this);
        }
        #endregion

        #region Methods

        /// <summary>
        /// Adds an action to the bill.
        /// </summary>
        /// <param name="actionDescription">The description of the action.</param>
        /// <param name="amount">The amount.</param>
        public void AddAction(string actionDescription, float amount)
        {
            var action = new Action(actionDescription, amount);
            AllActions.Add(action);
            //Database.MakeBillActionTriple(this, action);
            Amount += amount;
        }

        /// <summary>
        /// Calculates or updates the total amount on the bill.
        /// </summary>
        /// <returns>Returns the amount.</returns>
        public float CalculateAmount()
        {
            float f = 0;

            foreach (var a in AllActions)
                f += a.Amount;

            return f;
        }

        /// <summary>
        /// Removes an action on the bill.
        /// </summary>
        /// <param name="action">The action to be removed.</param>
        /// <returns>Returns <see cref="string.Empty"/> if the removal was successful, otherwise the description of the error.</returns>
        public string RemoveAction(Action action)
        {
            if (!AllActions.Contains(action)) return "The specified action cannot be found.";

            AllActions.Remove(action);
            return string.Empty;
        }
        #endregion
    }
}
