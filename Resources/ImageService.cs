using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Resources
{
    class ImageService
    {
        //From Iconic
        public static Image ListButtonDeleteIcon { get => CreateImage(@"\x-3x.png"); }
        public static Image ListButtonEditIcon { get => CreateImage(@"\pencil-3x.png"); }
        public static Image EditButtonIcon { get => CreateImage(@"\pencil-4x.png"); }
        public static Image SaveButtonIcon { get => CreateImage(@"\data-transfer-download-4x.png"); }
        public static Image AddButtonIcon { get => CreateImage(@"\plus-4x.png"); }
        public static Image CancelButtonIcon { get => CreateImage(@"\ban-4x.png"); }
        public static Image SettingsButtonIcon { get => CreateImage(@"\cog-4x.png"); }
        public static Image BackButtonIcon { get => CreateImage(@"\account-logout-3x.png"); }

        public static Icon MainIcon { get =>
            Icon.ExtractAssociatedIcon(
            Directory.GetParent(
                    Environment.CurrentDirectory)
                .Parent.Parent.FullName + @"\Resources\book-3x.ico"); }

        private static Image CreateImage(string filename)
            => Image.FromFile(
                Directory.GetParent(
                    Environment.CurrentDirectory)
                .Parent.Parent.FullName + 
                @"\Resources" +
                filename
            );
        
    }
}
