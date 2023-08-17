namespace WebAppAbra.Models
{
    public class RootModel
    {
        public UserModel[] userModels { get; set; }
        public InformationModel  Information { get; set; }
        public object UserModel { get; internal set; }
    }
}


