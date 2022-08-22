namespace ASP_NET_HW_Module_02_part_02
{
    public class SaveToFile
    {
        private IEnumerable<IInfo> info;
        public SaveToFile(IEnumerable<IInfo> info, string nameFile)
        {
            this.info = info;

            using FileStream fs = new FileStream($"../../../App_Data/{nameFile}.txt", FileMode.Append);
            using StreamWriter sw = new StreamWriter(fs);

            foreach (var item in info)
            {
                sw.WriteLine(item.Info(), true);
            }
        }
    }
}
