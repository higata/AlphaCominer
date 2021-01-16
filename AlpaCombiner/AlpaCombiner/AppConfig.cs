using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;

namespace AlpaCombiner
{
    internal class AppConfig : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        public string LastLoadedSrcImagePath
        {
            get
            {
                return (string)this["LastLoadedSrcImagePath"];
            }
            set
            {
                this["LastLoadedSrcImagePath"] = value;
            }
        }

        [UserScopedSetting()]
        public string LastLoadedGrayscaleImagePath
        {
            get
            {
                return (string)this["LastLoadedGrayscaleImagePath"];
            }
            set
            {
                this["LastLoadedGrayscaleImagePath"] = value;
            }
        }

        [UserScopedSetting()]
        public string LastSaveResultImagePath
        {
            get
            {
                return (string)this["LastSaveResultImagePath"];
            }
            set
            {
                this["LastSaveResultImagePath"] = value;
            }
        }

        [UserScopedSetting()]
        public Size LastWindowSize
        {
            get
            {
                if (this["LastWindowSize"] != null)
                {
                    return (Size)this["LastWindowSize"];
                }
                return Size.Empty;
            }
            set
            {
                this["LastWindowSize"] = value;
            }
        }
    }
}
