namespace ASPNETCOREMVC.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> list = new List<HomeModel>();

            item = new HomeModel();
            item.Id = 1;
            item.Name = "Guilherme";
            list.Add(item);

            item = new HomeModel();
            item.Id = 2;
            item.Name = "Aluno";
            list.Add(item);

            return list;
        }
    }
}
