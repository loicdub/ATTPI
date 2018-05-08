using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace projet_pre_tpi
{
    public class FingersPosition
    {
        private ArrayList listFingers;

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

        public FingersPosition()
        {
            listFingers = new ArrayList();
        }

        [XmlElement("finger")]
        public myHand[] Fingers
        {
            get
            {
                myHand[] fingers = new myHand[listFingers.Count];
                listFingers.CopyTo(fingers);
                return fingers;
            }
            set
            {
                if (value == null)
                    return;
                myHand[] fingers = (myHand[])value;
                listFingers.Clear();
                foreach (myHand finger in fingers)
                    listFingers.Add(finger);
            }
        }
        public int addHand(myHand finger)
        {
            return listFingers.Add(finger);
        }
    }

    public class myHand
    {
        [XmlElement("name")]
        public string name;
        [XmlElement("extended")]
        public bool isExtended;
        public myHand() { }
        public myHand(string name, bool thumb, bool index, bool middle, bool ring, bool pinky)
        {
            this.name = name;
        }
    }
}
