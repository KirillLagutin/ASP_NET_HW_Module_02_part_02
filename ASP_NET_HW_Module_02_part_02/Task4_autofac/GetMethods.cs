namespace ASP_NET_HW_Module_02_part_02.Task4_autofac
{
    public class GetMethods : IGetMethods
    {
        private readonly IKitchenAppliances[] _appliances;
        public GetMethods(IKitchenAppliances[] appliances)
        {
            _appliances = appliances;
        }

        public string GetKitchenApplianceById(int id)
        {
            string res = _appliances[id-1].Name + " " + _appliances[id-1].Action + Environment.NewLine;
            return res; 
        }

        public List<string> GetKitchenAppliances()
        {
            var res = new List<string>();
            foreach(var item in _appliances)
            {
                res.Add(item.Name + " " + item.Action + Environment.NewLine);
            }
            return res;
        }
    }
}
