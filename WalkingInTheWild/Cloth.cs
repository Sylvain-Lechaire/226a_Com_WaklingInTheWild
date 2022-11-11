namespace WalkingInTheWild
{
    public class Cloth
    {
        //region private attributes
        private string _brand;
        private bool _waterProof;
        //endregion private attributes

        //region public methods
        public Cloth(string brand, bool waterProof = false)
        {
            _brand = brand;
            _waterProof = waterProof;
            //throw new NotImplementedException();
        }

        public string Brand
        {
            get
            {
                return _brand;
                //throw new NotImplementedException();
            }
        }

        public bool IsWaterProof
        {

            get
            {
                return (_waterProof);
            }
            set
            {
                _waterProof = value;

            }

           

         
        }
        //endregion public methods

        //region private methods
        //endregion private methods

        //region nested classes
        public class ClothException : Exception { }
        public class AlreadyWaterProofException : ClothException { }
        //enregion  nested classes
    }
}