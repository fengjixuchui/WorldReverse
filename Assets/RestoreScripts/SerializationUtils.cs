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
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SerializationUtils // TypeDefIndex: 19572
{
    // Fields
    private static byte binKey; // 0x00
    public static Dictionary<System.Type, string> jsonDataMapping; // 0x08

    // Nested types
    public struct InvalidDataType // TypeDefIndex: 19573
    {
    }

    public enum PackedBinCategory // TypeDefIndex: 19574
    {
        NONEXCEL = 0,
        EXCEL = 1
    }

    // Constructors
    static SerializationUtils()
    {
        jsonDataMapping = new Dictionary<System.Type, string>();

        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigAbility>[]).TypeHandle), "LIST:Data/_JsonOutput/Ability");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAbilityPath).TypeHandle), "OBJT:Data/_JsonOutput/AbilityPath");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigGadgetPath).TypeHandle), "OBJT:Data/_JsonOutput/GadgetPath");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAnimPatternPath).TypeHandle), "OBJT:Data/_JsonOutput/AnimPattern");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigAudioEmitter>).TypeHandle), "DICT:Data/_JsonOutput/AudioEmitter");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAvatar).TypeHandle), "OBJT:Data/_JsonOutput/Avatar");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigBoundary>).TypeHandle), "DICT:Data/_JsonOutput/Boundary");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigCameraMove>).TypeHandle), "DICT:Data/_JsonOutput/SCameraMove");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigGlobalCombat).TypeHandle), "OBJT:Data/_JsonOutput/Common");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigEffectData).TypeHandle), "OBJT:Data/_JsonOutput/Effect");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigEffectPath).TypeHandle), "OBJT:Data/_JsonOutput/EffectPath");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigGadget>).TypeHandle), "DICT:Data/_JsonOutput/Gadget");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelMeta).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/Meta");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelActionPoint).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/ActionPoints");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelMonsterData).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/Monsters");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelRoute).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/Routes");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelPolygons).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/Polygons");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelGadgetData).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/Gadgets");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigPolygonArea).TypeHandle), "OBJT:Data/_JsonOutput/LevelDesign/SimplePolygons");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMonster).TypeHandle), "OBJT:Data/_JsonOutput/Monster");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigNpc).TypeHandle), "OBJT:Data/_JsonOutput/Npc");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigBaseShape>).TypeHandle), "DICT:Data/_JsonOutput/Shape");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigSkin>).TypeHandle), "DICT:Data/_JsonOutput/Skin");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigSoundBankLookup).TypeHandle), "OBJT:Data/_JsonOutput/SoundBank");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigTalentMixin>).TypeHandle), "DICT:Data/_JsonOutput/Talent");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigLevelEntity>).TypeHandle), "DICT:Data/_JsonOutput/LevelEntity");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigEmojiBubbleData>).TypeHandle), "DICT:Data/_JsonOutput/EmojiBubble");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigInterContainer).TypeHandle), "OBJT:Data/_JsonOutput/InterAction");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMapGlobal).TypeHandle), "OBJT:Data/_JsonOutput/Mark");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigScene).TypeHandle), "OBJT:Data/_JsonOutput/Scene/Point");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelLayout).TypeHandle), "OBJT:Data/_JsonOutput/Scene/LevelLayout");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigWorldAreaLayout).TypeHandle), "OBJT:Data/_JsonOutput/Scene/WorldArea");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelNpcBornPos).TypeHandle), "OBJT:Data/_JsonOutput/Scene/SceneNpcBorn");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelNpcBornPosNoGroup).TypeHandle), "OBJT:Data/_JsonOutput/Scene/SceneNpcBornNoGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMutiPlatformUIData).TypeHandle), "OBJT:Data/_JsonOutput/MultiPlatformUIData");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigPlatformGrahpicsSetting).TypeHandle), "OBJT:Data/_JsonOutput/GraphicsSetting");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigExternalVoiceItem>).TypeHandle), "DICT:Data/_JsonOutput/Voice/Items");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, string>).TypeHandle), "DICT:Data/_JsonOutput/Voice/Emo");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<uint, ConfigExternalVoiceLookupItem>).TypeHandle), "DICT:Data/_JsonOutput/Voice/Lut");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigEntityBanData).TypeHandle), "OBJT:Data/_JsonOutput/EntityBan");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigModeStateMap).TypeHandle), "OBJT:Data/_JsonOutput/PlayMode");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigGuideTask>).TypeHandle), "DICT:Data/_JsonOutput/Guide");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigUI).TypeHandle), "OBJT:Data/_JsonOutput/UI");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigUIGlobal).TypeHandle), "OBJT:Data/_JsonOutput/Global/Embeded/UI");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioStageEvents).TypeHandle), "OBJT:Data/_JsonOutput/StageAudio");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAttachmentData).TypeHandle), "OBJT:Data/_JsonOutput/AttachData");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMarkGlobal).TypeHandle), "OBJT:Data/_JsonOutput/Global/Mark");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigJobData).TypeHandle), "OBJT:Data/_JsonOutput/Schedule");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigTextMapLevel).TypeHandle), "OBJT:Data/_JsonOutput/Global/Embeded/TextMap");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigFullPreload).TypeHandle), "OBJT:Data/_JsonOutput/Preload");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigCutsceneIndex).TypeHandle), "OBJT:Data/_JsonOutput/Cutscene");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigCrowdGroupInfo[]).TypeHandle), "LIST:Data/_JsonOutput/CrowdGroupInfos");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigCrowdSpawnInfos).TypeHandle), "OBJT:Data/_JsonOutput/CrowdSpawnInfos");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<uint, long>).TypeHandle), "DICT:Data/_JsonOutput/IndexDic");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMainQuestScheme).TypeHandle), "OBJT:Data/_JsonOutput/Quest");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMainQuestBrief).TypeHandle), "OBJT:Data/_JsonOutput/QuestBrief");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigNpcTalkScheme).TypeHandle), "OBJT:Data/_JsonOutput/Talk/NpcGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigFreeDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/Npc");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/Quest");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigNarratorDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/FreeGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigBlossomDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/Blossom");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigCoopDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/Coop");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigTalkScheme).TypeHandle), "OBJT:Data/_JsonOutput/Talk/BlossomGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigActivityDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/Activity");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigActivityTalkScheme).TypeHandle), "OBJT:Data/_JsonOutput/Talk/ActivityGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigGadgetDialogGroup).TypeHandle), "OBJT:Data/_JsonOutput/Talk/Gadget");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigGadgetTalkScheme).TypeHandle), "OBJT:Data/_JsonOutput/Talk/GadgetGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLogoPageSetting).TypeHandle), "OBJT:Data/_JsonOutput/LogoPage");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLuaHack).TypeHandle), "OBJT:Data/_JsonOutput/LuaHackConfig");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMainCoopGroup).TypeHandle), "OBJT:Data/_JsonOutput/Coop");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioAmbience).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Ambience");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioAvatar).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Avatar");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioAvatarMove).TypeHandle), "OBJT:Data/_JsonOutput/Audio/AvatarMove");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioBaseMove).TypeHandle), "OBJT:Data/_JsonOutput/Audio/BaseMove");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioCamera).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Camera");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioCityBlocks).TypeHandle), "OBJT:Data/_JsonOutput/Audio/CityBlocks");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioCombat).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Combat");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioDialog).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Dialog");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioGadget).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Gadget");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioGameViewState).TypeHandle), "OBJT:Data/_JsonOutput/Audio/GameViewState");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioGeneral).TypeHandle), "OBJT:Data/_JsonOutput/Audio/General");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioLevel).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Level");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioListener).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Listener");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioMapInfo).TypeHandle), "OBJT:Data/_JsonOutput/Audio/MapInfo");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioMusic).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Music");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioMutualExclusion).TypeHandle), "OBJT:Data/_JsonOutput/Audio/MutualExclusion");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioNpc).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Npc");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioQuest).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Quest");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioResource).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Resource");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioSurfaceType).TypeHandle), "OBJT:Data/_JsonOutput/Audio/SurfaceType");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioUi).TypeHandle), "OBJT:Data/_JsonOutput/Audio/UI");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioWeather).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Weather");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAvatarSpeech).TypeHandle), "OBJT:Data/_JsonOutput/Audio/AvatarSpeech");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioSetting).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Setting");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioMIDI).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Midi");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMusic).TypeHandle), "OBJT:Data/_JsonOutput/Music/Music");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigPS4TRC).TypeHandle), "OBJT:Data/_JsonOutput/PS4/Embedded");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMusicCondition[]).TypeHandle), "LIST:Data/_JsonOutput/Music/TransitionConditions");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigSong[]).TypeHandle), "LIST:Data/_JsonOutput/Music/Songs");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigPlatformActionTokenChannel).TypeHandle), "OBJT:Data/_JsonOutput/AbilityActionChannel");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigEntityAbilitySystem).TypeHandle), "OBJT:Data/_JsonOutput/AbilitySystem");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigUIIndicator>).TypeHandle), "DICT:Data/_JsonOutput/Indicator");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioArea2DAmbience[]).TypeHandle), "LIST:Data/_JsonOutput/Audio/Area2DAmbience");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigFlycloakFashion>).TypeHandle), "DICT:Data/_JsonOutput/Fashion/Flycloak");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLCBaseInteeData).TypeHandle), "OBJT:Data/_JsonOutput/Component/LCBaseIntee");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLCGadgetInteeData).TypeHandle), "OBJT:Data/_JsonOutput/Component/LCGadgetIntee");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigResonanceCutSceneMap).TypeHandle), "OBJT:Data/_JsonOutput/Goddess");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigSpatialAudio).TypeHandle), "OBJT:Data/_JsonOutput/Audio/Spatial");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAudioEventCulling).TypeHandle), "OBJT:Data/_JsonOutput/Audio/EventCulling");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLanguageSetting).TypeHandle), "OBJT:Data/_JsonOutput/LanguageSetting");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigWidget).TypeHandle), "OBJT:Data/_JsonOutput/Widget");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMainWidgetToy).TypeHandle), "OBJT:Data/_JsonOutput/WidgetNew");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigClimate).TypeHandle), "OBJT:Data/_JsonOutput/Climate");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigAbilityGroup>).TypeHandle), "DICT:Data/_JsonOutput/AbilityGroup");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigKeyboardLayout).TypeHandle), "OBJT:Data/_JsonOutput/KeyboardLayout");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigDynamicAbilityPreload>).TypeHandle), "DICT:Data/_JsonOutput/DynamicAbilityPreload");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigEntityReuseData).TypeHandle), "OBJT:Data/_JsonOutput/EntityReuse");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigCodexQuest).TypeHandle), "OBJT:Data/_JsonOutput/CodexQuest");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigLevelPolygon).TypeHandle), "OBJT:Data/_JsonOutput/StreamPolygon");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigAnimator).TypeHandle), "OBJT:Data/_JsonOutput/AnimatorConfig");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigGlobalValues).TypeHandle), "OBJT:Data/_JsonOutput/Global/GlobalValues");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(Dictionary<string, ConfigMainPageDisableInfo>).TypeHandle), "DICT:Data/_JsonOutput/MainPageDisableInfo");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMusicGame).TypeHandle), "OBJT:Data/_JsonOutput/MusicGame");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigMusicGameCamera).TypeHandle), "OBJT:Data/_JsonOutput/MusicGameCamera");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigHomePlaceColPath).TypeHandle), "OBJT:Data/_JsonOutput/Homeworld");
        jsonDataMapping.Add(System.Type.GetTypeFromHandle(typeof(ConfigHomeworldFurnitureSet).TypeHandle), "OBJT:Data/_JsonOutput/HomeworldFurnitureSuit");


        for (int i = 0; i < GlobalVars.ScriptVersion.LastIndexOf("."); ++i)
        {
            binKey = (byte)(binKey + GlobalVars.ScriptVersion.ToCharArray()[i]);
        }
        if (binKey == 0) binKey++;
    } // 0x00000001815A86C0-0x00000001815A9D00

    // Methods
    // [XID] // 0x00000001896D0980-0x00000001896D09A0
    public static ulong GetHash(string binPath) => default; // 0x00000001815A80D0-0x00000001815A8220
                                                            // [XID] // 0x0000000189A7B030-0x0000000189A7B050
    public static string ToJsonPath(string binPath)
    {
        if (binPath != null)
        {
            binPath = binPath.Replace("_BinOutput", "_JsonOutput");
        }
        return binPath;
    }// 0x00000001815A8220-0x00000001815A82E0
     // [XID] // 0x000000018972A8A0-0x000000018972A8C0
    public static void DecodeBin(ByteArray byteArr)
    {
        for (int i = 0; i < byteArr.bytes.Length; i++)
        {
            byteArr.bytes[i] ^= binKey;
        }
    } // 0x00000001815A7500-0x00000001815A7650
      // [IDTag] // 0x00000001896E6B40-0x00000001896E6B80
      // [XID] // 0x00000001896E6B40-0x00000001896E6B80
    public static ByteArray ReadPackedBin(string sourcePath)
    {
        var binData = CommonMiscs.LoadBinData(sourcePath);
        ByteArray array = ByteArray.Get();
        if (binData != null)
        {
            array.bytes = binData;
            DecodeBin(array);
        }
        else
        {
            array.bytes = null;
            SuperDebug.LogError("Binary file is broken in file:" + sourcePath);
        }
        return array;
    }// 0x00000001815A7650-0x00000001815A7800
     // [XID] // 0x00000001896F0E00-0x00000001896F0E20
    public static void ReadPackedBinAsync(string sourcePath, Action<ByteArray> finishCallback, PackedBinCategory category = PackedBinCategory.NONEXCEL /* Metadata: 0x00AFCB03 */) { } // 0x00000001815A7DF0-0x00000001815A7FF0
                                                                                                                                                                                       // [IDTag] // 0x00000001896F8620-0x00000001896F8660
                                                                                                                                                                                       // [XID] // 0x00000001896F8620-0x00000001896F8660
    public static ByteArray ReadPackedBin(ulong sourcePathHash) => default; // 0x00000001815A7800-0x00000001815A79C0
    public static string GetDataToolTraversingFolder<T>() => default;
    // [XID] // 0x0000000189702F70-0x0000000189702F90
    public static ToBinType GetJsonFolder(System.Type type, ref string folderPath) => default; // 0x00000001815A82E0-0x00000001815A8570
                                                                                               // [XID] // 0x000000018970A640-0x000000018970A660
    public static ToBinType GetToBinType(string jsonFilePath, ref System.Type dataType) => default; // 0x00000001815A79C0-0x00000001815A7DF0
                                                                                                    // [XID] // 0x00000001897120B0-0x00000001897120D0
    private static ToBinType ParseToBinType(string entry) => default; // 0x00000001815A8570-0x00000001815A86C0
                                                                      // [XID] // 0x0000000189719750-0x0000000189719770
    public static ulong GetPathFormHash(ConfigMetaConfig.PathHash pathHash) => default; // 0x00000001815A7FF0-0x00000001815A80D0
}

