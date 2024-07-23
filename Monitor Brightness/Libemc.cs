
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Monitor_Brightness
{
    public static class Libemc
    {
        [DllImport("libemc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint EmCtrlFind(
          Libemc.EmCtrlCommunicationPass pass,
          uint passSize);

        [DllImport("libemc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Emerror.EmError EmCtrlRelease();

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetSerialProduct(
          uint index,
          StringBuilder serial,
          StringBuilder product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetHIDHandle(
          string serial,
          string product,
          ref IntPtr handle);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedBrightness(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetBrightnessForStep(
          string serial,
          string product,
          ref uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetBrightnessForStep(
          string serial,
          string product,
          uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetBrightnessForPercentage(
          string serial,
          string product,
          ref double pPercentage);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetBrightnessForPercentage(
          string serial,
          string product,
          double pPercentage);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedColorTemperature(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetColorTemperature(
          string serial,
          string product,
          uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetColorTemperature(
          string serial,
          string product,
          ref uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedFineContrast(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlEnumFineContrast(
          string serial,
          string product,
          uint index,
          ref Libemc.EmCtrlFineContrast value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern int EmCtrlGetFineContrastCount(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetFineContrast(
          string serial,
          string product,
          ref Libemc.EmCtrlFineContrast value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetFineContrast(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedFineContrastSkip(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetFineContrastSkip(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast fcMode,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetFineContrastSkip(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast fcMode,
          bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern uint EmCtrlGetFineContrastNameSize(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetFineContrastName(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast fcMode,
          StringBuilder modeName,
          uint size);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetFCInformation(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast fcMode,
          ref Libemc.EMC_FC_INFORMATION pSupportedFlags);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedContrast(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetRangeContrastForStep(
          string serial,
          string product,
          ref uint pMax,
          ref uint pMin,
          ref uint pDefault);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetContrastForPercentage(
          string serial,
          string product,
          ref double pPercentage);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetContrastForStep(
          string serial,
          string product,
          ref uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetContrastForStep(
          string serial,
          string product,
          uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetContrastForPercentage(
          string serial,
          string product,
          double pPercentage);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedGamma(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlEnumGamma(
          string serial,
          string product,
          uint index,
          ref double value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetGamma(
          string serial,
          string product,
          ref double value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetGamma(
          string serial,
          string product,
          double value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedGain(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetRangeGain(
          string serial,
          string product,
          ref int max,
          ref int min);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetGain(
          string serial,
          string product,
          ref uint value,
          Libemc.EmCtrlRGBParameter rgbParam);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetGain(
          string serial,
          string product,
          uint value,
          Libemc.EmCtrlRGBParameter rgbParam);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedUsageTime(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetUsageTime(
          string serial,
          string product,
          ref Libemc.EMC_USAGETIME value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedBrightRegulator(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetBrightRegulator(
          string serial,
          string product,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetBrightRegulator(
          string serial,
          string product,
          bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedPower(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetPower(
          string serial,
          string product,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetPower(
          string serial,
          string product,
          bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedSplitDisplayMode(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetSplitDisplayMode(
          string serial,
          string product,
          ref Libemc.EmCtrlSplitDisplayMode displayMode);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedPowerSaveState(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetPowerSaveState(
          string serial,
          string product,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedPowerSaveSetting(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetPowerSaveSetting(
          string serial,
          string product,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetPowerSaveSetting(
          string serial,
          string product,
          bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedInputSignalMode(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetInputSignalMode(
          string serial,
          string product,
          ref Libemc.EmCtrlInputSignalMode value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedInputPort(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetInputPort(
          string serial,
          string product,
          Libemc.EmCtrlInputPort port);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetInputPort(
          string serial,
          string product,
          ref Libemc.EmCtrlInputPort port);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEcoViewSense(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEcoViewSense(
          string serial,
          string product,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEcoViewSense(
          string serial,
          string product,
          bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEcoViewSensePowerState(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEcoViewSensePowerState(
          string serial,
          string product,
          ref Libemc.EmCtrlEcoViewSensePowerState state);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedKeyLockSetting(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetKeyLockState(
          string serial,
          string product,
          ref Libemc.EmCtrlKeyLockState state);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetKeyLockState(
          string serial,
          string product,
          Libemc.EmCtrlKeyLockState state);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlShowIndicatorOSD(
          string serial,
          string product,
          ref Libemc.EmCtrlKeyLockState keyLocked);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlHideIndicatorOSD(
          string serial,
          string product,
          Libemc.EmCtrlKeyLockState keyLocked);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSave(
          string serial,
          string product,
          Libemc.EmCtrlSaveParameter param);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedUSBPowerSave(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetUSBPowerSave(
          string serial,
          string product,
          ref bool on);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetUSBPowerSave(
          string serial,
          string product,
          bool on);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedFactoryPanelLuminance(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetFactoryPanelLuminance(
          string serial,
          string product,
          ref Libemc.EmCtrlFactoryPanelLuminance rgbw);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedOutsidePhotoSensorAD(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetOutsidePhotoSensorAD(
          string serial,
          string product,
          ref uint value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedCompatibilityMode(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetCompatibilityMode(
          string serial,
          string product,
          ref bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetCompatibilityMode(
          string serial,
          string product,
          bool value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEnableWholeWindowColorSetting(
          string serial,
          string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEnableWholeWindowColorSetting(
          string serial,
          string product,
          ref bool enable);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEnableWholeWindowColorSetting(
          string serial,
          string product,
          bool enable);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEVActiveWindow(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEVActiveWindow(
          string serial,
          string product,
          Libemc.EmCtrlEVActiveWindow window);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEVActiveWindow(
          string serial,
          string product,
          ref Libemc.EmCtrlEVActiveWindow window);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedGainDefinition(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetGainDefinition(
          string serial,
          string product,
          IntPtr gainDefList);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedUSBPowerDelivery(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetUSBPowerDelivery(
          string serial,
          string product,
          ref Libemc.EmCtrlUSBPowerDelivery pValue);

        [DllImport("libemc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void EmCtrlSetThreadUnsafeOption(bool Unsafe);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedAutoEcoViewSettings(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetAutoEcoViewSettings(
          string serial,
          string product,
          ref Libemc.EmCtrlAutoEcoViewSettings settings);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetAutoEcoViewSettings(
          string serial,
          string product,
          Libemc.EmCtrlAutoEcoViewSettings settings);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedAutoEcoViewSettingsV2(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetAutoEcoViewSettingsV2(
          string serial,
          string product,
          ref Libemc.EmCtrlAutoEcoViewSettingsV2 settings);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetAutoEcoViewSettingsV2(
          string serial,
          string product,
          Libemc.EmCtrlAutoEcoViewSettingsV2 settings);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEcoViewSenseSensitivity(
          string serial,
          string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEcoViewSenseSensitivity(
          string serial,
          string product,
          ref Libemc.EmCtrlEcoViewSenseSensitivity sensitivity);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEcoViewSenseSensitivity(
          string serial,
          string product,
          Libemc.EmCtrlEcoViewSenseSensitivity sensitivity);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEcoViewSenseTimeIndex(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEcoViewSenseTimeIndex(
          string serial,
          string product,
          ref Libemc.EmCtrlEcoViewSenseTimeIndex time);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEcoViewSenseTimeIndex(
          string serial,
          string product,
          Libemc.EmCtrlEcoViewSenseTimeIndex time);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEcoViewOptimizer(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEcoViewOptimizerEnable(
          string serial,
          string product,
          ref bool enable);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEcoViewOptimizerEnable(
          string serial,
          string product,
          bool enable);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEcoViewOptimizerStatus(
          string serial,
          string product,
          ref bool isAdjustable);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        private static extern bool EmCtrlSupportedFCFunction(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast fcMode,
          Libemc.EmCtrlFCFunction fcFunc);

        public static bool EmCtrlSupportedFCFunctionExtension(
          string serial,
          string product,
          Libemc.EmCtrlFineContrast fcMode,
          Libemc.EmCtrlFCFunction fcFunc)
        {
            bool isAdjustable = false;
            switch (fcFunc)
            {
                case Libemc.EmCtrlFCFunction.EMC_FC_FUNCTION_ECOVIEW_OPTIMIZER2:
                    int viewOptimizerStatus = (int)Libemc.EmCtrlGetEcoViewOptimizerStatus(serial, product, ref isAdjustable);
                    break;
                case Libemc.EmCtrlFCFunction.EMC_FC_FUNCTION_AUTO_ECOVIEW:
                    isAdjustable = fcMode != Libemc.EmCtrlFineContrast.EMC_FC_DICOMCB && fcMode != Libemc.EmCtrlFineContrast.EMC_FC_UNDEFINED;
                    break;
                case Libemc.EmCtrlFCFunction.EXTENSION_ECOVIEW_SENSE:
                    isAdjustable = true;
                    break;
                default:
                    isAdjustable = Libemc.EmCtrlSupportedFCFunction(serial, product, fcMode, fcFunc);
                    break;
            }
            return isAdjustable;
        }

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedDPVersion(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetDPVersion(
          string serial,
          string product,
          ref Libemc.EmCtrlDPVersion dpVersion);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedEVCustomKeyLock(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetEVCustomKeyLock(
          string serial,
          string product,
          ref uint combination);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetEVCustomKeyLock(
          string serial,
          string product,
          uint combination);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlReset(
          string serial,
          string product,
          Libemc.EmCtrlResetParameter param);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern bool EmCtrlSupportedAudioVolume(string serial, string product);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlGetAudioVolume(
          string serial,
          string product,
          ref ulong value);

        [DllImport("libemc.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ThrowOnUnmappableChar = true, BestFitMapping = false)]
        public static extern Emerror.EmError EmCtrlSetAudioVolume(
          string serial,
          string product,
          ulong value);

        public enum EmCtrlCommunicationPass : uint
        {
            EMC_CP_USB,
            EMC_CP_DDCCI,
            EMC_CP_DDCCI_2,
        }

        public enum EmCtrlRGBParameter : uint
        {
            EMC_PARAM_R,
            EMC_PARAM_G,
            EMC_PARAM_B,
            EMC_PARAM_WHITE,
        }

        public struct EMC_FC_INFORMATION
        {
            public bool flgBrightness;
            public bool flgContrast;
            public bool flgColortemperature;
            public bool flgGamma;
            public bool flgSaturation;
            public bool flgHue;
            public bool flgGain;
            public bool flgEXContrast;
            public bool flgSharpness;
            public bool flgBlackLevel;
            public bool flg6ColorsAdjustment;
            public bool flgReset;
        }

        public enum EmCtrlFineContrast : uint
        {
            EMC_FC_TEXT = 0,
            EMC_FC_PICTURE = 1,
            EMC_FC_MOVIE = 2,
            EMC_FC_CUSTOM = 3,
            EMC_FC_SRGB = 4,
            EMC_FC_EXT = 5,
            EMC_FC_VIEWER = 6,
            EMC_FC_CAL = 7,
            EMC_FC_DICOMCB = 8,
            EMC_FC_DICOMBB = 9,
            EMC_FC_EMU = 10, // 0x0000000A
            EMC_FC_CAL1 = 11, // 0x0000000B
            EMC_FC_CAL2 = 12, // 0x0000000C
            EMC_FC_CAL3 = 13, // 0x0000000D
            EMC_FC_CAD = 14, // 0x0000000E
            EMC_FC_CIE = 15, // 0x0000000F
            EMC_FC_FL = 16, // 0x00000010
            EMC_FC_GAME = 17, // 0x00000011
            EMC_FC_REC709 = 18, // 0x00000012
            EMC_FC_EBU = 19, // 0x00000013
            EMC_FC_SMPTEC = 20, // 0x00000014
            EMC_FC_DCI = 21, // 0x00000015
            EMC_FC_USER1 = 22, // 0x00000016
            EMC_FC_USER2 = 23, // 0x00000017
            EMC_FC_USER3 = 24, // 0x00000018
            EMC_FC_RESERVED1 = 25, // 0x00000019
            EMC_FC_RESERVED2 = 26, // 0x0000001A
            EMC_FC_RESERVED3 = 27, // 0x0000001B
            EMC_FC_CGCAL1 = 28, // 0x0000001C
            EMC_FC_CGCAL2 = 29, // 0x0000001D
            EMC_FC_CGCAL3 = 30, // 0x0000001E
            EMC_FC_EYECARE = 31, // 0x0000001F
            EMC_FC_ADOBERGB = 32, // 0x00000020
            EMC_FC_CINEMA = 33, // 0x00000021
            EMC_FC_PAPER = 34, // 0x00000022
            EMC_FC_HYBRID_GAMMA = 35, // 0x00000023
            EMC_FC_ECO = 36, // 0x00000024
            EMC_FC_ALT = 37, // 0x00000025
            EMC_FC_DAY = 38, // 0x00000026
            EMC_FC_NIGHT = 39, // 0x00000027
            EMC_FC_FPS1 = 40, // 0x00000028
            EMC_FC_FPS2 = 41, // 0x00000029
            EMC_FC_RTS = 42, // 0x0000002A
            EMC_FC_WEB = 43, // 0x0000002B
            EMC_FC_GAME_DARKSCENE = 44, // 0x0000002C
            EMC_FC_GAME_LIGHTSCENE = 45, // 0x0000002D
            EMC_FC_WEB_SRGB = 46, // 0x0000002E
            EMC_FC_USER = 47, // 0x0000002F
            EMC_FC_REC2020 = 48, // 0x00000030
            EMC_FC_UNDEFINED = 4294967295, // 0xFFFFFFFF
        }

        public struct EMC_USAGETIME
        {
            public uint usageHour;
            public uint usageMinute;
        }

        public enum EmCtrlSplitDisplayMode : uint
        {
            EMC_SPLIT_DISPLAY_MODE_SINGLE,
            EMC_SPLIT_DISPLAY_MODE_PBYP,
            EMC_SPLIT_DISPLAY_MODE_PINP,
        }

        public enum EmCtrlInputSignalMode : uint
        {
            EMC_ISM_ANALOG,
            EMC_ISM_DEGITAL,
            EMC_ISM_UNKNOWN,
        }

        public enum EmCtrlInputPort : uint
        {
            EMC_IP_UNDEFINED = 0,
            EMC_IP_DSUB1 = 10, // 0x0000000A
            EMC_IP_DSUB2 = 11, // 0x0000000B
            EMC_IP_DVI1 = 20, // 0x00000014
            EMC_IP_DVI2 = 21, // 0x00000015
            EMC_IP_DP1 = 30, // 0x0000001E
            EMC_IP_DP2 = 31, // 0x0000001F
            EMC_IP_HDMI1 = 40, // 0x00000028
            EMC_IP_HDMI2 = 41, // 0x00000029
            EMC_IP_SDI1 = 50, // 0x00000032
            EMC_IP_SDI2 = 51, // 0x00000033
            EMC_IP_SDIAB = 52, // 0x00000034
            EMC_IP_SDIBA = 53, // 0x00000035
            EMC_IP_D1 = 60, // 0x0000003C
            EMC_IP_D2 = 61, // 0x0000003D
            EMC_IP_COMPOSITE1 = 70, // 0x00000046
            EMC_IP_COMPOSITE2 = 71, // 0x00000047
            EMC_IP_TV1 = 80, // 0x00000050
            EMC_IP_TV2 = 81, // 0x00000051
        }

        public enum EmCtrlEcoViewSensePowerState : uint
        {
            EMC_EVSENSE_POWERSTATE_RESERVED = 0,
            EMC_EVSENSE_POWERSTATE_NOSIGNAL = 1,
            EMC_EVSENSE_POWERSTATE_ABSENSE = 2,
            EMC_EVSENSE_POWERSTATE_DCOFF = 3,
            EMC_EVSENSE_POWERSTATE_EXPECT = 255, // 0x000000FF
        }

        public enum EmCtrlKeyLockState : uint
        {
            EMC_KEYLOCK_OFF = 0,
            EMC_KEYLOCK_COLOR = 1,
            EMC_KEYLOCK_CHILD = 2,
            EMC_KEYLOCK_CUSTOM = 3,
            EMC_KEYLOCK_ALL = 10, // 0x0000000A
        }

        public enum EmCtrlSaveParameter : uint
        {
            EMC_SAVE_CALIBRATIONRESULT,
            EMC_SAVE_COLOR,
            EMC_SAVE_3DLUT,
            EMC_SAVE_MEDIAEMU_1DLUT,
            EMC_SAVE_MEDIAEMU_3DLUT,
            EMC_SAVE_ECOVIEWSENSE,
            EMC_SAVE_PINP_PBYP,
            EMC_SAVE_CAL_PARAMETER_TO_DICOMCB,
            EMC_SAVE_CAL_PARAMETER_TO_DICOMBB,
            EMC_SAVE_OUTPUT_SEGMENT_PROPERTY,
            EMC_SAVE_ECOVIEWSENSE_SETTING,
            EMC_SAVE_IIS_AREA_PROPERTY,
            EMC_SAVE_AUDIO_SETTING,
        }

        public struct EmCtrlFactoryPanelLuminance
        {
            public double red;
            public double green;
            public double blue;
            public double white;
        }

        public enum EmCtrlEVActiveWindow : uint
        {
            EMC_EV_ACTIVEWINDOW_WINDOW_1,
            EMC_EV_ACTIVEWINDOW_WINDOW_2,
            EMC_EV_ACTIVEWINDOW_WINDOW_3,
            EMC_EV_ACTIVEWINDOW_WINDOW_4,
        }

        public struct EmCtrlGainDefinition
        {
            public byte red;
            public byte green;
            public byte blue;
            public uint colorTemp;
        }

        public enum EmCtrlUSBPowerDelivery : uint
        {
            EMC_USBPOWERDELIVERY_NORMAL,
            EMC_USBPOWERDELIVERY_HIGH,
        }

        public enum EmCtrlAutoEcoViewAmbientLightLevel : uint
        {
            EMC_AUTOEV_AMBIENTLIGHT_DARK,
            EMC_AUTOEV_AMBIENTLIGHT_STANDARD,
            EMC_AUTOEV_AMBIENTLIGHT_BRIGHT,
        }

        public struct EmCtrlAutoEcoViewSettings
        {
            public ushort maxPointBrightness;
            public Libemc.EmCtrlAutoEcoViewAmbientLightLevel maxPointAmbientLightLevel;
            public ushort minPointBrightness;
            public Libemc.EmCtrlAutoEcoViewAmbientLightLevel minPointAmbientLightLevel;
            public ushort inflectionPointBrightness;
            public ushort inflectionPointAmbientLight;
            public ushort adjustMarginBrightness;
            public bool isAdjustableBrightness;
        }

        public struct EmCtrlAutoEcoViewSettingsV2
        {
            public ushort brightPointBrightness;
            public ushort brightPointAmbientLight;
            public ushort darkPointBrightness;
            public ushort darkPointAmbientLight;
            public ushort inflectionPointAmbientLight;
        }

        public enum EmCtrlEcoViewSenseSensitivity : uint
        {
            EMC_EVSENSE_SENSITIVITY_1,
            EMC_EVSENSE_SENSITIVITY_2,
            EMC_EVSENSE_SENSITIVITY_3,
            EMC_EVSENSE_SENSITIVITY_4,
            EMC_EVSENSE_SENSITIVITY_5,
        }

        public enum EmCtrlEcoViewSenseTimeIndex : uint
        {
            EMC_EVSENSE_TIME_5SEC,
            EMC_EVSENSE_TIME_30SEC,
            EMC_EVSENSE_TIME_1MIN,
            EMC_EVSENSE_TIME_3MIN,
            EMC_EVSENSE_TIME_5MIN,
            EMC_EVSENSE_TIME_10MIN,
            EMC_EVSENSE_TIME_15MIN,
            EMC_EVSENSE_TIME_30MIN,
            EMC_EVSENSE_TIME_45MIN,
            EMC_EVSENSE_TIME_60MIN,
        }

        public enum EmCtrlFCFunction : uint
        {
            EMC_FC_FUNCTION_BRIGHTNESS = 0,
            EMC_FC_FUNCTION_CONTRAST = 1,
            EMC_FC_FUNCTION_COLORTEMP = 2,
            EMC_FC_FUNCTION_GAMMA = 3,
            EMC_FC_FUNCTION_SATURATION = 4,
            EMC_FC_FUNCTION_HUE = 5,
            EMC_FC_FUNCTION_GAIN = 6,
            EMC_FC_FUNCTION_EXTEND_CONTRAST = 7,
            EMC_FC_FUNCTION_SHARPNESS = 8,
            EMC_FC_FUNCTION_BLACK_LEVEL = 9,
            EMC_FC_FUNCTION_6COLORS_ADJUSTMENT = 14, // 0x0000000E
            EMC_FC_FUNCTION_RESET = 15, // 0x0000000F
            EMC_FC_FUNCTION_ECOVIEW_OPTIMIZER2 = 26, // 0x0000001A
            EMC_FC_FUNCTION_AUTO_ECOVIEW = 27, // 0x0000001B
            EXTENSION_ECOVIEW_SENSE = 200, // 0x000000C8
        }

        public enum EmCtrlDPVersion : uint
        {
            EMC_DP_VERSION_1_1,
            EMC_DP_VERSION_1_2,
        }

        public enum EmCtrlResetParameter : uint
        {
            EMC_RESET_OTHER = 0,
            EMC_RESET_COLOR = 1,
            EMC_RESET_AUDIO = 2,
            EMC_RESET_3DLUT = 3,
            EMC_RESET_MEDIAEMU_1DLUT = 4,
            EMC_RESET_MEDIAEMU_3DLUT = 5,
            EMC_RESET_MONITOR_CONFIGURATOR = 7,
        }
    }
}
