using System.Runtime.InteropServices;

namespace WalkingInTheWild
{
    public class Bagpack
    {
        //region private attributes
        private List<Cloth> _clothes;
        private List<Equipment> _equipments;
        private readonly float _maxLoad;    
        //endregion private attributes

        //region public methods
        public Bagpack(float maxLoad)
        { 
            _maxLoad = maxLoad; 
            _clothes = new List<Cloth>();   
            _equipments = new List<Equipment>();    

            //throw new NotImplementedException();
        }
        
        public List<Cloth> Clothes
        {
            get
            {
                
                return _clothes;
                //throw new NotImplementedException();
            }
        }

        public List<Equipment> Equipments
        {
            get
            {
                return _equipments;

               // throw new NotImplementedException();
            }
        }

        public float RemainingLoadCapacity
        {
            get
            {
                return _equipments.Count;
                return _clothes.Count;
                return _maxLoad;
                //throw new NotImplementedException();
            }
        }

        public void Add(Cloth cloth)
        {
            
            this._clothes.Add(cloth);
            //throw new NotImplementedException();
        }

        public void Add(Equipment equipment)
        {
            this.Equipments.Add(equipment);
            //throw new NotImplementedException();
        }
        //endregion public methods

        //region private methods
        //endregion private methods

        //region nested classes
        public class BagpackException : Exception { }
        public class MaximumLoadReachedException : BagpackException { }
        //enregion  nested classes
    }
}