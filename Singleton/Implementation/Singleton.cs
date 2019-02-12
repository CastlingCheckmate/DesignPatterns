namespace SingletonPattern.Implementation
{

    internal class Singleton
    {
        
        #region Static fields

        private static Singleton _instance;

        #endregion

        #region Constructors

        private Singleton()
        {

        }

        #endregion

        #region Static properties

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instance)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion

    }

}