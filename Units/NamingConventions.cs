namespace Units
{
    public class NamingConventions
    {
        // Const fields get "baked" into code. They are literally placed as their value
        // when you use them. So any change of them requires recompilation of code
        // where they are used.
        private const int ConstInt = 5;

        // this will be placed/copied as raw bytes whenever used
        private const string ConstString = "aaaa";

        // can assign value at this point
        private static readonly int StaticReadonlyField = 6;

        private static readonly int StaticReadonlyFieldInitializedFromConstructor;

        private static string StaticField;

        // this will be referenced as variable
        private readonly string _readonlyField = "aaaaa";

        private readonly string _readonlyFieldInitializedFromConstructor;

        private int _field;

        private int _publicPropertyBackingField;

        // no protected or public fields! -> encapsulation
        // if anything needs to be accessible outside of this class, wrap it in property

        /// <summary>
        /// Constructor can be static so it can initialzie static fields
        /// </summary>
        static NamingConventions()
        {
            StaticReadonlyField = 5;

            // cannot initialize instance variable inside of static constructor
            //_readonlyFieldInitializedFromConstructor = "from static constructor";
        }

        public NamingConventions()
        {
            // cannot assign readonly static field outside of static construcor
            // in this case it is also static,
            //StaticReadonlyField = 1;

            _readonlyFieldInitializedFromConstructor = "from normal constructor";
        }

        // protected constructor can be called only by derived classes
        protected NamingConventions(int x)
        {
        }


        // this is for special cases when we don't want to let user create instance
        // see: Singleton
        private NamingConventions(double y)
        {
        }

        public static string PublicStaticProperty
        {
            get
            {
                return StaticField;
            }

            set
            {
                StaticField = value;
            }
        }

        public int PublicProperty
        {
            get
            {
                return _publicPropertyBackingField;
            }

            set
            {
                // value is special word (read about properties from link I sent in email)
                _publicPropertyBackingField = value;
            }
        }

        // this is exactly same as above (public property with backing field)
        // it is for our convenience, when we want to expose something, but don't need to have backing field
        public int PublicAutoProperty { get; set; }

        protected int NowProtectedProperties { get; set; }

        private string NowPrivateProperties { get; set; }

        public void NowPublicMethods()
        {
        }

        protected void NowProtectedMethods()
        {
        }

        private void NowPrivateMethods()
        {
        }

        // other things: when needed, you'll know how to check where to place them ;)
        // but general pattern for access modifiers is: public, protected, private
        // for type modifiers: const, static readonly, static, readonly, normal
        // for all items: fields, constructors, properties, methods
        // and alphabetically (I didn't care here for this)
    }
}
