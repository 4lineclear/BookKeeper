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
        public static Image ListButtonDeleteIcon { get => CreateImage(@"\Resources\x-3x.png"); }
        public static Image ListButtonEditIcon { get => CreateImage(@"\Resources\pencil-3x.png"); }
        public static Image EditButtonIcon { get => CreateImage(@"\Resources\pencil-4x.png"); }
        public static Image SaveButtonIcon { get => CreateImage(@"\Resources\data-transfer-download-4x.png"); }
        public static Image AddButtonIcon { get => CreateImage(@"\Resources\plus-4x.png"); }
        public static Image CancelButtonIcon { get => CreateImage(@"\Resources\ban-4x.png"); }
        public static Image SettingsButtonIcon { get => CreateImage(@"\Resources\cog-4x.png"); }
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
                filename
            );
        
    }
}
