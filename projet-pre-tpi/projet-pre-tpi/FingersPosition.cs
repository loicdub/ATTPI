using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_pre_tpi
{
    class FingersPosition
    {
        #region get-set
        private string _name;
        private bool _thumb;
        private bool _index;
        private bool _middle;
        private bool _ring;
        private bool _pinky;

        public string Name { get => _name; set => _name = value; }
        public bool Thumb { get => _thumb; set => _thumb = value; }
        public bool Index { get => _index; set => _index = value; }
        public bool Middle { get => _middle; set => _middle = value; }
        public bool Ring { get => _ring; set => _ring = value; }
        public bool Pinky { get => _pinky; set => _pinky = value; }
        #endregion

        public FingersPosition() { }
    }
}
