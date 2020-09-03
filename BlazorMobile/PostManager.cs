using System;
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
    public class PostManager
    {
        public ObservableCollection<Post> MyPosts = new ObservableCollection<Post>();
        HttpClient myClient = new HttpClient();

        public async Task<ObservableCollection<Post>> GetPosts()
        {
            var response = await myClient.GetAsync(Constants.POSTRestfulAPIEndpoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MyPosts = JsonConvert.DeserializeObject<ObservableCollection<Post>>(content);
            }

            return MyPosts;
        }

        public PostManager()
        {
        }
    }
}
