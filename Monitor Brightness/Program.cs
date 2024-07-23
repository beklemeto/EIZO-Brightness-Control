using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace Monitor_Brightness
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = "55410105";
            string product = "EV2450";
            

            Emerror.EmError result;

            // find monitors and initialize library
            uint monitors = Libemc.EmCtrlFind(Libemc.EmCtrlCommunicationPass.EMC_CP_USB, 1U);
            Debug.Assert(monitors >= 0);
            
            StringBuilder s = new StringBuilder();
            StringBuilder p= new StringBuilder();
            result = Libemc.EmCtrlGetSerialProduct(monitors-1, s, p);
            Debug.Assert(Emerror.EmSUCCEEDED(result));

            serial = s.ToString();
            product = p.ToString();

            // change brightness
            if (Libemc.EmCtrlSupportedBrightness(serial, product))
            {
                uint brightness = 0;
                result = Libemc.EmCtrlGetBrightnessForStep(serial, product, ref brightness);
                Debug.Assert(Emerror.EmSUCCEEDED(result));
                brightness += 10;
                result = Libemc.EmCtrlSetBrightnessForStep(serial, product, brightness);
                Debug.Assert(Emerror.EmSUCCEEDED(result));
            }

            // change color
            if (Libemc.EmCtrlSupportedGain(serial, product))
            {
                uint white = 0;
                result = Libemc.EmCtrlGetGain(serial, product, ref white, Libemc.EmCtrlRGBParameter.EMC_PARAM_R);
                Debug.Assert(Emerror.EmSUCCEEDED(result));
                white -= 10;
                result = Libemc.EmCtrlSetGain(serial, product, white, Libemc.EmCtrlRGBParameter.EMC_PARAM_R);
                Debug.Assert(Emerror.EmSUCCEEDED(result));
            }


            result = Libemc.EmCtrlRelease();
            Debug.Assert(Emerror.EmSUCCEEDED(result));
        }
    }
}
