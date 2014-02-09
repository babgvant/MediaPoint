﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using DirectShowLib;

namespace MediaPoint.Common.Interfaces
{

    public enum TDCFilterType
    {
        ftNone,
        ftAmplify,
        ftBandPass,
        ftChannelOrder,
        ftCompressor,
        ftDownMix,
        ftDynamicAmplify,
        ftEchoDelay,
        ftEqualizer,
        ftFlanger,
        ftHighPass,
        ftLowPass,
        ftNotch,
        ftPhaseInvert,
        ftPhaser,
        ftPitchScale,
        ftPitchShift,
        ftSound3D,
        ftTempo,
        ftTrebleEnhancer,
        ftTrueBass,
        ftDMOChorus,
        ftDMOCompressor,
        ftDMODistortion,
        ftDMOEcho,
        ftDMOFlanger,
        ftDMOGargle,
        ftDMOI3DL2Reverb,
        ftDMOParamEQ,
        ftDMOWavesReverb,
        ftParametricEQ,
    }

    public enum TDCBitRate
    {
        br8BitInteger,
        br16BitInteger,
        br24BitInteger,
        br32BitInteger,
        br32BitFloat,
    }

    public enum TDCFFTSize
    {
        fts2,
        fts4,
        fts8,
        fts16,
        fts32,
        fts64,
        fts128,
        fts256,
        fts512,
        fts1024,
        fts2048,
        fts4096,
        fts8192,
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct TDSStream
    {
        public int Size;
        public int Frequency;
        public int Channels;
        [MarshalAsAttribute(UnmanagedType.Bool)]
        public bool _Float;
        [MarshalAsAttribute(UnmanagedType.Bool)]
        public bool SPDIF;
        [MarshalAsAttribute(UnmanagedType.Bool)]
        public bool DTS;
    }

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
    Guid("3971C5D4-1FDA-45C1-9131-C817326A4348"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDCDSPFilterPCMCallBack
    {
        [PreserveSig]
        int PCMDataCB(ref int Buffer, int Length, ref int NewSize, ref TDSStream Stream);

        [PreserveSig]
        int MediaTypeChanged(ref TDSStream Stream);

        [PreserveSig]
        int Flush();
    }

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
    Guid("BD78EF46-1809-11D6-A458-EDAE78F1DF12"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDCDSPFilterInterface : IBaseFilter
    {
        [PreserveSig]
        int set_CallBackPCM(ref IDCDSPFilterPCMCallBack Callback);

        [PreserveSig]
        int set_PCMDataBeforeMainDSP(bool before);

        // winamp DPS plugins

        [PreserveSig]
        int set_DSPPlugin(IntPtr WindowHandle, [MarshalAs(UnmanagedType.LPStr)]string Path);
        
        [PreserveSig]
        int get_DSPPlugin([MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]ref StringBuilder Path);
        
        [PreserveSig]
        int get_DSPCount(ref int Count);
        
        [PreserveSig]
        int get_DSPDescription([MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]ref StringBuilder Description);
        
        [PreserveSig]
        int get_DSPSubDescription(int index, [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]ref StringBuilder Description);
        
        [PreserveSig]
        int set_DSPSubPlugin(int index);
        
        [PreserveSig]
        int get_DSPSubPlugin(ref int index);

        [PreserveSig]
        int set_ShowConfig();

        // winamp vis plugins

        [PreserveSig]
        int set_UnloadDSPPlugin();
        
        [PreserveSig]
        int get_EnableDSPPlug([MarshalAsAttribute(UnmanagedType.Bool)] ref bool Enable);
        
        [PreserveSig]
        int set_EnableDSPPlug([MarshalAsAttribute(UnmanagedType.Bool)] bool Enable);
        
        [PreserveSig]
        int set_PluginOwnerWindow(IntPtr Window);

        // Winamp Vis Plugins
        
        [PreserveSig]
        int get_WinampVisInterval(ref int Interval) ;
        
        [PreserveSig]
        int set_WinampVisInterval(int Interval) ;
        
        [PreserveSig]
        int get_WinampVisPlugin([MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]ref StringBuilder Plugin, ref int Index) ;
        
        [PreserveSig]
        int set_WinampVisPlugin([MarshalAs(UnmanagedType.LPStr)] string Plugin, int Index) ;
        
        [PreserveSig]
        int get_WinampVisAutostart([MarshalAsAttribute(UnmanagedType.Bool)] ref bool Autostart);
        
        [PreserveSig]
        int set_WinampVisAutostart([MarshalAsAttribute(UnmanagedType.Bool)] bool Autostart);
        
        [PreserveSig]
        int set_StopWinampVisPlugin();

        // Delay functions for delaying the Audio Stream through Timestamps
        [PreserveSig]
        int get_EnableDelay([MarshalAsAttribute(UnmanagedType.Bool)] ref bool Enabled);
        [PreserveSig]
        int set_EnableDelay([MarshalAsAttribute(UnmanagedType.Bool)] bool Enabled);
        [PreserveSig]
        int get_Delay( ref int Delay);
        [PreserveSig]
        int set_Delay( int Delay);

        [PreserveSig]
        int get_FilterCount(ref int Count);
        [PreserveSig]
        int get_FilterType(int Index, ref TDCFilterType FilterType);
        [PreserveSig]
        int set_AddFilter(int Index, TDCFilterType FilterType);
        [PreserveSig]
        int get_FilterName(int Index, [MarshalAs(UnmanagedType.LPStr)] StringBuilder Name);
        [PreserveSig]
        int get_WindowShown(int Index, ref bool Shown);
        [PreserveSig]
        int set_WindowShown(int Index, bool Shown);
        [PreserveSig]
        int set_DeleteFilter(int Index);
        [PreserveSig]
        int get_EnableFilter(int Index, ref bool Enabled);
        [PreserveSig]
        int set_EnableFilter(int Index, bool Enabled);
        [PreserveSig]
        int set_RemoveAllFilters();
        [PreserveSig]
        int set_MoveFilter(int FromIndex, int ToIndex);
        [PreserveSig]
        int set_ResetShownWindows();
        [PreserveSig]
        int get_FilterClass(int Index, [MarshalAs(UnmanagedType.Interface)] out object ppUnk); // usage within Delphi
        [PreserveSig]
        int get_FilterInterface(int Index, [MarshalAs(UnmanagedType.Interface)] out object ppUnk);
        [PreserveSig]
        int get_FilterItem( int Index, [MarshalAs(UnmanagedType.Interface)] out object ppUnk); // for internal use only!
        [PreserveSig]
        int get_PresetCount(ref int Count);
        [PreserveSig]
        int get_PresetExist( [MarshalAs(UnmanagedType.LPStr)] string preset, ref bool Exist);
        [PreserveSig]
        int get_PresetName(int Index, [MarshalAs(UnmanagedType.LPStr, SizeConst = 260)]ref StringBuilder Name);
        [PreserveSig]
        int set_LoadPreset([MarshalAs(UnmanagedType.LPStr)] string Name);
        [PreserveSig]
        int set_SavePreset([MarshalAs(UnmanagedType.LPStr)] string Name);
        [PreserveSig]
        int set_DeletePreset([MarshalAs(UnmanagedType.LPStr)] string Name);

    }

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
    Guid("3FB0116F-52EE-4286-BF3A-65C0055EAA45"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDCAmplify
    {
        int get_Enabled(ref bool aEnabled);
        int set_Enabled(bool  aEnabled);
        int get_Seperate(ref bool aSeperate);
        int set_Seperate(bool  aSeperate);
        int get_Volume(byte aChannel, ref int aVolume);
        int set_Volume(byte aChannel, int aVolume);
    };

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
    Guid("9496B84F-BC7B-4230-889D-1ADCC790D237"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDCDownMix
    {
        int get_Enabled(ref bool aEnabled);
        int set_Enabled(bool aEnabled);
    };

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
    Guid("14D4A709-77ED-459B-B1E9-E4E4C84261BD"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDCEqualizer
    {
        [PreserveSig]
        int get_Enabled(ref bool aEnabled);
        [PreserveSig]
        int set_Enabled(bool aEnabled);
        [PreserveSig]
        int get_Seperate(bool aSeperate);
        [PreserveSig]
        int set_Seperate(bool aSeperate);
        [PreserveSig]
        int get_FFTSize(ref TDCFFTSize aFFTSize);
        [PreserveSig]
        int set_FFTSize(TDCFFTSize aFFTSize);
        [PreserveSig]
        int get_Band(byte aChannel, ushort aIndex, ref sbyte aBand);
        [PreserveSig]
        int set_Band(byte aChannel, ushort aIndex, sbyte aBand);
    };
}
