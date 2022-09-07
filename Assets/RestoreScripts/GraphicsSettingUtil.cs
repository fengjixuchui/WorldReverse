/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GraphicsSettingUtil // TypeDefIndex: 31556
{
    // Fields
    private static Texture2D _dither_8x8_diag_tex; // 0x00
    private static Texture2D _dither_4x4_tex; // 0x08
    private static bool _haveInitialDitherMatrix; // 0x10
    public static int _lastTargetFrameRate; // 0x14
    private static Dictionary<int, ShadowCascadeParam> _shadowDistanceParamMap; // 0x18
    private static int _screenWidth; // 0x20
    private static int _screenHeight; // 0x24
    public static float secondTargetScaleForDebug; // 0x38
    private const float DEFAULT_DPI = 360f; // Metadata: 0x00B1294B
    private static float _refDpi; // 0x3C
    private static float _dpi; // 0x40
    private static float _deviceWidthInch; // 0x44
    private static float _deviceHeightInch; // 0x48
    private static int _origDeviceWidth; // 0x4C
    private static int _origDeviceHeight; // 0x50
    private static int _lastDeviceWidth; // 0x54
    private static int _lastDeviceHeight; // 0x58
    private static int _maxScreenWidth; // 0x5C
    private static int _maxScreenHeight; // 0x60
    private static float _inputDPI; // 0x64
    private static int _inputWidth; // 0x68
    private static int _inputHeight; // 0x6C
    public static readonly string[] ShaderQualityStrs; // 0x70
    private static TerrainGrassViewDistanceConfig _terrainGrassViewDistanceConfig; // 0x78
    private static string TERRAIN_GRASS_CONFIG_PATH; // 0x80

    // Properties
    public static int screenWidth { /* [XID] */ /* 0x00000001895ED090-0x00000001895ED0B0 */ get; } // 0x00000001811E5E60-0x00000001811E5F30 
    public static int screenHeight { /* [XID] */ /* 0x00000001895F4750-0x00000001895F4770 */ get; } // 0x00000001811E6090-0x00000001811E6160 
    public static int PostProcessWidth { /* [XID] */ /* 0x0000000189603960-0x00000001896039A0 */ get; /* [XID] */ /* 0x000000018960E070-0x000000018960E0B0 */ private set; } // 0x00000001811E7C30-0x00000001811E7CC0 0x00000001811E5930-0x00000001811E59C0
    public static int PostProcessHeight { /* [XID] */ /* 0x00000001896189F0-0x0000000189618A30 */ get; /* [XID] */ /* 0x0000000189622C90-0x0000000189622CD0 */ private set; } // 0x00000001811E7AA0-0x00000001811E7B30 0x00000001811E5F30-0x00000001811E5FC0
    public static int PostProcessSecondWidth { /* [XID] */ /* 0x000000018962D460-0x000000018962D4A0 */ get; /* [XID] */ /* 0x0000000189638220-0x0000000189638260 */ private set; } // 0x00000001811E67C0-0x00000001811E6850 0x00000001811E4D80-0x00000001811E4E10
    public static int PostProcessSecondHeight { /* [XID] */ /* 0x0000000189642620-0x0000000189642660 */ get; /* [XID] */ /* 0x000000018964CEF0-0x000000018964CF30 */ private set; } // 0x00000001811E4CF0-0x00000001811E4D80 0x00000001811E3420-0x00000001811E34B0
    public static float dpi { /* [XID] */ /* 0x0000000189727C00-0x0000000189727C20 */ get; } // 0x00000001811E1DB0-0x00000001811E1E80 
    public static float RefDPI { /* [XID] */ /* 0x000000018972F1F0-0x000000018972F210 */ get; } // 0x00000001811E13C0-0x00000001811E1A90 
    public static float deviceWidthInch { /* [XID] */ /* 0x000000018974D520-0x000000018974D540 */ get; } // 0x00000001811E6DD0-0x00000001811E6EA0 
    public static float deviceHeightInch { /* [XID] */ /* 0x0000000189754BD0-0x0000000189754BF0 */ get; } // 0x00000001811E1100-0x00000001811E11D0 
    public static int maxScreenWidth { /* [XID] */ /* 0x000000018975BD90-0x000000018975BDB0 */ get; } // 0x00000001811E3560-0x00000001811E3630 
    public static int maxScreenHeight { /* [XID] */ /* 0x0000000189763730-0x0000000189763750 */ get; } // 0x00000001811E6160-0x00000001811E6230 
    public static int originDeviceWidth { /* [XID] */ /* 0x000000018976AF70-0x000000018976AF90 */ get; } // 0x00000001811E79D0-0x00000001811E7AA0 
    public static int originDeviceHeight { /* [XID] */ /* 0x00000001897725C0-0x00000001897725E0 */ get; } // 0x00000001811E12F0-0x00000001811E13C0 

    // Nested types
    private struct ShadowCascadeParam // TypeDefIndex: 31557
    {
        // Fields
        public Vector3 cascadeSplit; // 0x00
        public Vector4 distParam; // 0x0C

        // Constructors
        public ShadowCascadeParam(Vector3 split, Vector4 dist)
        {
            cascadeSplit = default;
            distParam = default;
        } // 0x0000000181203890-0x0000000181203A70
    }

    // Constructors
    static GraphicsSettingUtil() { } // 0x00000001811E7E50-0x00000001811E80F0

    // Methods
    // [XID] // 0x0000000189BB4B10-0x0000000189BB4B30
    private static Dictionary<int, ShadowCascadeParam> GetShadowDistanceParamMap() => default; // 0x00000001811E3630-0x00000001811E3B00
                                                                                               // [XID] // 0x0000000189BBC0C0-0x0000000189BBC0E0
    public static void SetTargetFrameRate(int targetFrameRate) { } // 0x00000001811E5800-0x00000001811E5930
                                                                   // [XID] // 0x0000000189BC3E00-0x0000000189BC3E20
    public static void SetGlobalShaderParams()
    {
        //自定义引擎字段
        //RenderSettings.disableParticleTrailLineRender = false;
        //RenderSettings.disableTransWithoutParticleTrailLine = false;
        Shader.SetGlobalVector(VCCharacterRendering._pointLightColorID, Vector4.zero);
        Shader.SetGlobalVector(VCCharacterRendering._overrideLightDirID, Vector4.zero);
        Shader.SetGlobalVector(VCCharacterRendering._overrideLightDirInShadowID, Vector4.zero);
        Shader.SetGlobalFloat("mhyUsingMultiSampleDepth", 0f);
        SetShadowDistanceQuality(false);
        var ditehr8x8 = new float[64];
        Shader.SetGlobalFloatArray("_Ditehr_8x8_Diag_Pattern", ditehr8x8);
        if (_dither_8x8_diag_tex == null)
        {
            _dither_8x8_diag_tex = new Texture2D(8, 8, TextureFormat.Alpha8, false, true);
            _dither_8x8_diag_tex.name = "_Ditehr_8x8_Diag_Pattern_Tex";
            _dither_8x8_diag_tex.hideFlags = HideFlags.HideAndDontSave;
            _dither_8x8_diag_tex.filterMode = FilterMode.Point;
            _dither_8x8_diag_tex.wrapMode = TextureWrapMode.Repeat;
            Color[] color = new Color[ditehr8x8.Length];
            for (int i = 0; i < color.Length; i++)
            {
                var curDitehr = ditehr8x8[i];
                color[i + 1] = new Color(curDitehr * 0.03125f, curDitehr * 0.03125f, curDitehr * 0.03125f, curDitehr * 0.03125f);
            }
            _dither_8x8_diag_tex.SetPixels(color);
            _dither_8x8_diag_tex.Apply();
            Shader.SetGlobalTexture(_dither_8x8_diag_tex.name, _dither_8x8_diag_tex);
        }
        var ditehr4x4 = new float[16];
        if (_dither_4x4_tex == null)
        {
            _dither_4x4_tex = new Texture2D(4, 4, TextureFormat.Alpha8, false, true);
            _dither_4x4_tex.name = "_Ditehr_4x4_Pattern_Tex";
            _dither_4x4_tex.hideFlags = HideFlags.HideAndDontSave;
            _dither_4x4_tex.filterMode = FilterMode.Point;
            _dither_4x4_tex.wrapMode = TextureWrapMode.Repeat;
            Color[] color = new Color[ditehr4x4.Length];
            for (int i = 0; i < color.Length; i++)
            {
                var curDitehr = ditehr4x4[i];
                color[i + 1] = new Color(curDitehr * 0.0625f, curDitehr * 0.0625f, curDitehr * 0.0625f, curDitehr * 0.0625f);
            }
            _dither_4x4_tex.SetPixels(color);
            _dither_4x4_tex.Apply();
            Shader.SetGlobalTexture(_dither_4x4_tex.name, _dither_4x4_tex);
        }
        if (!_haveInitialDitherMatrix)
        {
            Matrix4x4 matrix = Matrix4x4.identity;
            matrix.SetRow(0, new Vector4(1f, 9f, 3f, 11f));
            matrix.SetRow(1, new Vector4(13f, 5f, 15f, 7f));
            matrix.SetRow(2, new Vector4(4f, 12f, 2f, 10f));
            matrix.SetRow(3, new Vector4(16f, 8f, 14f, 6f));
            Shader.SetGlobalMatrix("_DITHERMATRIX", matrix);
            _haveInitialDitherMatrix = true;
        }
    } // 0x00000001811E4210-0x00000001811E4CF0
      // [IDTag] // 0x0000000189BCB6E0-0x0000000189BCB720
      // [XID] // 0x0000000189BCB6E0-0x0000000189BCB720
    public static void SetShadowDistanceQuality(bool isHigh = false /* Metadata: 0x00B12941 */) { } // 0x00000001811E6EA0-0x00000001811E7120
                                                                                                    // [XID] // 0x0000000189BD59E0-0x0000000189BD5A00
    public static void SetLoginShadowDistanceQuality(float distance, Vector4 disVec, Vector3 splitVec, ShadowResolution type) { } // 0x00000001811E32B0-0x00000001811E3420
                                                                                                                                  // [IDTag] // 0x0000000189BDD5C0-0x0000000189BDD600
                                                                                                                                  // [XID] // 0x0000000189BDD5C0-0x0000000189BDD600
    public static void SetShadowDistanceQuality(ShadowQuality shadowGrade) { } // 0x00000001811E7120-0x00000001811E79D0
                                                                               // [XID] // 0x00000001895FBF40-0x00000001895FBF60
    public static void InitScreenResolution() { } // 0x00000001811E4130-0x00000001811E4210
                                                  // [XID] // 0x0000000189657520-0x0000000189657540
    public static void InitPostProcessResolution() { } // 0x00000001811E2D20-0x00000001811E32B0
                                                       // [XID] // 0x000000018965EBE0-0x000000018965EC00
    public static void SetCameraPostProcessResolution(Camera camera) { } // 0x00000001811E2070-0x00000001811E2780
                                                                         // [XID] // 0x0000000189666240-0x0000000189666260
    private static void SetPCPostProcessScale(float scale, PostProcessLayer layer) { } // 0x00000001811E6C60-0x00000001811E6DD0
                                                                                       // [XID] // 0x000000018966DA00-0x000000018966DA20
    public static void UpdatePCPostProcessScale() { } // 0x00000001811E0420-0x00000001811E05D0
                                                      // [XID] // 0x0000000189675820-0x0000000189675840
    private static bool GetRecommendScreenResolution(ref int screenWidth, ref int screenHeight) => default; // 0x00000001811E5D50-0x00000001811E5E60
                                                                                                            // [XID] // 0x000000018967D130-0x000000018967D150
    private static bool GetRecommendPostProcessResolution(ref int postProcessWidth, ref int postProcessHeight, ref int postProcessSecondWidth, ref int postProcessSecondHeight, float screenPercentage) => default; // 0x00000001811E1E80-0x00000001811E1F60
                                                                                                                                                                                                                    // [XID] // 0x00000001896847A0-0x00000001896847C0
    private static void GetResolutionKeepScale(int recommendWidth, int recommendHeight, ref int resX, ref int resY) { } // 0x00000001811E6850-0x00000001811E69E0
                                                                                                                        // [XID] // 0x000000018968C350-0x000000018968C370
    public static void ShrinkScale(int refWidth, int refHeight, ref int width, ref int height) { } // 0x00000001811E64A0-0x00000001811E6640
                                                                                                   // [XID] // 0x0000000189693E00-0x0000000189693E20
    public static void ApplyResolution(int screenWidth, int screenHeight, int postProcessSecondWidth, int postProcessSecondHeight, int postProcessWidth, int postProcessHeight) { } // 0x00000001811E2780-0x00000001811E2BA0
                                                                                                                                                                                    // [XID] // 0x000000018969B3B0-0x000000018969B3D0
    public static void OnApplicationPause(bool isPause) { } // 0x00000001811E1F60-0x00000001811E2070
                                                            // [XID] // 0x00000001896A2B10-0x00000001896A2B30
    public static void InitRenderSetting(Camera renderCamera, bool isMainCamera = true /* Metadata: 0x00B12942 */, StageType stageType = StageType.World /* Metadata: 0x00B12943 */) { } // 0x00000001811E4E10-0x00000001811E5800
                                                                                                                                                                                         // [XID] // 0x00000001896A9F90-0x00000001896A9FB0
    public static void SetupBloomGrade(MHYBloom mhyBloom) { } // 0x00000001811E3B00-0x00000001811E3D40
                                                              // [XID] // 0x00000001896B0D10-0x00000001896B0D30
    public static void InitBloomSettings(out MHYBloom mhyBloom)
    {
        mhyBloom = default;
    } // 0x00000001811E0E40-0x00000001811E1100
      // [XID] // 0x00000001896B89A0-0x00000001896B89C0
    private static void EnableMotionBlur(Camera camera, bool enable, MotionBlur.MotionBlurQuality quality) { } // 0x00000001811E69E0-0x00000001811E6C60
                                                                                                               // [XID] // 0x00000001896BFBC0-0x00000001896BFBE0
    private static void EnableTAA(Camera camera, TemporalAntialiasing.TAAQuality quality = TemporalAntialiasing.TAAQuality.TAALow /* Metadata: 0x00B12947 */) { } // 0x00000001811E6370-0x00000001811E64A0
                                                                                                                                                                  // [XID] // 0x00000001896C74B0-0x00000001896C74D0
    private static void EnableSMAA(Camera camera, SubpixelMorphologicalAntialiasing.SMAAQualityPreset quality) { } // 0x00000001811E1C10-0x00000001811E1DB0
                                                                                                                   // [XID] // 0x00000001896CEC10-0x00000001896CEC30
    private static void InitPostprocessEffectSetting_Fallback(Camera mainCamera, StageType stageType) { } // 0x00000001811E6640-0x00000001811E67C0
                                                                                                          // [XID] // 0x00000001896D6010-0x00000001896D6030
    private static void InitParticleQualitySetting_Fallback(Camera camera, StageType stageType) { } // 0x00000001811E1B40-0x00000001811E1C10
                                                                                                    // [XID] // 0x00000001896DD5B0-0x00000001896DD5D0
    public static void Reset() { } // 0x00000001811E1A90-0x00000001811E1B40
                                   // [XID] // 0x00000001896E4CA0-0x00000001896E4CC0
    public static void EnableDoF(bool enable) { } // 0x00000001811E4020-0x00000001811E4130
                                                  // [XID] // 0x0000000189776B00-0x0000000189776B20
    public static void EnableDisplacementMesh(bool enable, int reason) { } // 0x00000001811E11D0-0x00000001811E12F0
                                                                           // [XID] // 0x00000001896F3990-0x00000001896F39B0
    public static void ResetDisplacementMesh(int reason) { } // 0x00000001811E7B30-0x00000001811E7C30
                                                             // [XID] // 0x00000001896FB030-0x00000001896FB050
    public static void InitLightSetting() { } // 0x00000001811E0D40-0x00000001811E0E40
                                              // [XID] // 0x0000000189702760-0x0000000189702780
    public static void InitUIManager() { } // 0x00000001811E2BA0-0x00000001811E2D20
                                           // [XID] // 0x0000000189709F90-0x0000000189709FB0
    public static void InitEntityLODManager() { } // 0x00000001811E3D40-0x00000001811E3EC0
                                                  // [XID] // 0x0000000189711A10-0x0000000189711A30
    public static void InitLevelStreaming() { } // 0x00000001811E6230-0x00000001811E6370
                                                // [XID] // 0x0000000189718E50-0x0000000189718E70
    public static void InitAvatarGraphicsThresh() { } // 0x00000001811E3EC0-0x00000001811E4020
                                                      // [XID] // 0x00000001897205F0-0x0000000189720610
    public static void InitVSyncSetting() { } // 0x00000001811E5FC0-0x00000001811E6090
                                              // [XID] // 0x00000001896D5CC0-0x00000001896D5CE0
    private static float GetDPI() => default; // 0x00000001811E34B0-0x00000001811E3560
                                              // [XID] // 0x000000018973E780-0x000000018973E7A0
    private static void InitInputDPI() { } // 0x00000001811E59C0-0x00000001811E5D50
                                           // [XID] // 0x00000001896C72F0-0x00000001896C7310
    public static void InitDPISetting() { } // 0x00000001811E05D0-0x00000001811E0D40
                                            // [XID] // 0x0000000189779BD0-0x0000000189779BF0
    public static void SetShaderQuality(string shaderQualityKeyword) { } // 0x00000001811E7CC0-0x00000001811E7E50
                                                                         // [XID] // 0x00000001897817F0-0x0000000189781810
    public static void InitComprehensiveSetting() { } // 0x00000001811DFB00-0x00000001811E0420
}

