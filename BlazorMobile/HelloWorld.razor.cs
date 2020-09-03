using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace BlazorMobile
{
    public partial class HelloWorld
    {
        public ObservableCollection<Post> PostsToBind = new ObservableCollection<Post>();

        protected override async Task OnInitializedAsync()
        {
            await FetchData();
            await base.OnInitializedAsync();
        }

        public HelloWorld()
        {
            
        }

        public async Task FetchData()
        {
            PostManager VM = new PostManager();
            PostsToBind = await VM.GetPosts();
        }
    }
}
