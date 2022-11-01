using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.Models;

namespace MusicStore.ViewModels
{
    //action method in the album controller is going to process this and send the data to a view
    public class ArtistViewModel
    {
        public List<Album> Album { get; set; }
        public List<Artist> Artist { get; set; }
    }
}
