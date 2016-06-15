using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using RecyclerVIewSample.Core.Models;

namespace RecyclerVIewSample.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private List<Item> _items = new List<Item>
        {
            new Item() {Text = "1", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "2", Url = "http://0.visuels.poliris.com/2d/0/a/3/7/0a37c1c6-7111.jpg"},
            new Item() {Text = "3", Url = "http://dyn.visuels.poliris.com/logosPublications/tny/8/312968.png"},
            new Item() {Text = "4", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "5", Url = "http://e.visuels.poliris.com/2d/e/1/d/5/e1d54395-23a9.jpg"},

            new Item() {Text = "1", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "2", Url = "http://0.visuels.poliris.com/2d/0/a/3/7/0a37c1c6-7111.jpg"},
            new Item() {Text = "3", Url = "http://dyn.visuels.poliris.com/logosPublications/tny/8/312968.png"},
            new Item() {Text = "4", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "5", Url = "http://e.visuels.poliris.com/2d/e/1/d/5/e1d54395-23a9.jpg"},

            new Item() {Text = "1", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "2", Url = "http://0.visuels.poliris.com/2d/0/a/3/7/0a37c1c6-7111.jpg"},
            new Item() {Text = "3", Url = "http://dyn.visuels.poliris.com/logosPublications/tny/8/312968.png"},
            new Item() {Text = "4", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "5", Url = "http://e.visuels.poliris.com/2d/e/1/d/5/e1d54395-23a9.jpg"},

            new Item() {Text = "1", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "2", Url = "http://0.visuels.poliris.com/2d/0/a/3/7/0a37c1c6-7111.jpg"},
            new Item() {Text = "3", Url = "http://dyn.visuels.poliris.com/logosPublications/tny/8/312968.png"},
            new Item() {Text = "4", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "5", Url = "http://e.visuels.poliris.com/2d/e/1/d/5/e1d54395-23a9.jpg"},

            new Item() {Text = "1", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "2", Url = "http://0.visuels.poliris.com/2d/0/a/3/7/0a37c1c6-7111.jpg"},
            new Item() {Text = "3", Url = "http://dyn.visuels.poliris.com/logosPublications/tny/8/312968.png"},
            new Item() {Text = "4", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "5", Url = "http://e.visuels.poliris.com/2d/e/1/d/5/e1d54395-23a9.jpg"},

            new Item() {Text = "1", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "2", Url = "http://0.visuels.poliris.com/2d/0/a/3/7/0a37c1c6-7111.jpg"},
            new Item() {Text = "3", Url = "http://dyn.visuels.poliris.com/logosPublications/tny/8/312968.png"},
            new Item() {Text = "4", Url = "http://a.visuels.poliris.com/2d/a/b/a/e/abaeb9c9-378c.jpg"},
            new Item() {Text = "5", Url = "http://e.visuels.poliris.com/2d/e/1/d/5/e1d54395-23a9.jpg"}
        };
        public List<Item> Items
        { 
            get { return _items; }
            set { SetProperty (ref _items, value); }
        }
    }
}
