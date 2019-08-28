using DAL.Interface;

namespace DAL
{
    public class ValueRepository : IValueRepository
    {
        public string[] GetValues()
            => new string[] { "valueFromRepository1", "valueFromRepository2" }; 
    }
}