/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole.Config;
using UnityEngine;
using XLua.CSObjectWrap;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class ObjectTranslator // TypeDefIndex: 32348
	{
		// Fields
		private static IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj; // 0x00
		private int UnityEngineVector2_TypeID; // 0x10
		private int UnityEngineVector3_TypeID; // 0x14
		private int UnityEngineVector4_TypeID; // 0x18
		private int UnityEngineColor_TypeID; // 0x1C
		private int UnityEngineQuaternion_TypeID; // 0x20
		private int UnityEngineRay_TypeID; // 0x24
		private int UnityEngineBounds_TypeID; // 0x28
		private int UnityEngineRay2D_TypeID; // 0x2C
		private int MoleMoleConfigRouteType_TypeID; // 0x30
		private int MoleMoleConfigRouteType_EnumRef; // 0x34
		private int MoleMoleConfigRotType_TypeID; // 0x38
		private int MoleMoleConfigRotType_EnumRef; // 0x3C
		private int MoleMoleConfigRotAngleType_TypeID; // 0x40
		private int MoleMoleConfigRotAngleType_EnumRef; // 0x44
		private int MoleMoleConfigActorType_TypeID; // 0x48
		private int MoleMoleConfigActorType_EnumRef; // 0x4C
		private int MoleMoleConfigTaskID_TypeID; // 0x50
		private int MoleMoleConfigTaskID_EnumRef; // 0x54
		private int MoleMoleConfigInterTimingType_TypeID; // 0x58
		private int MoleMoleConfigInterTimingType_EnumRef; // 0x5C
		private int MoleMoleConfigActorEvtTargetType_TypeID; // 0x60
		private int MoleMoleConfigActorEvtTargetType_EnumRef; // 0x64
		private int MoleMoleConfigWeatherType_TypeID; // 0x68
		private int MoleMoleConfigWeatherType_EnumRef; // 0x6C
		private int MoleMoleConfigLuaTaskType_TypeID; // 0x70
		private int MoleMoleConfigLuaTaskType_EnumRef; // 0x74
		private int MoleMoleConfigQuestType_TypeID; // 0x78
		private int MoleMoleConfigQuestType_EnumRef; // 0x7C
		private int MoleMoleConfigQuestState_TypeID; // 0x80
		private int MoleMoleConfigQuestState_EnumRef; // 0x84
		private int MoleMoleConfigParentQuestState_TypeID; // 0x88
		private int MoleMoleConfigParentQuestState_EnumRef; // 0x8C
		private int MoleMoleConfigQuestShowType_TypeID; // 0x90
		private int MoleMoleConfigQuestShowType_EnumRef; // 0x94
		private int MoleMoleConfigQuestCondCompareType_TypeID; // 0x98
		private int MoleMoleConfigQuestCondCompareType_EnumRef; // 0x9C
		private int MoleMoleConfigQuestCondType_TypeID; // 0xA0
		private int MoleMoleConfigQuestCondType_EnumRef; // 0xA4
		private int MoleMoleConfigQuestGuideType_TypeID; // 0xA8
		private int MoleMoleConfigQuestGuideType_EnumRef; // 0xAC
		private int MoleMoleConfigQuestGuideNPCSelectType_TypeID; // 0xB0
		private int MoleMoleConfigQuestGuideNPCSelectType_EnumRef; // 0xB4
		private int MoleMoleConfigShowQuestGuideType_TypeID; // 0xB8
		private int MoleMoleConfigShowQuestGuideType_EnumRef; // 0xBC
		private int MoleMoleConfigQuestExecType_TypeID; // 0xC0
		private int MoleMoleConfigQuestExecType_EnumRef; // 0xC4
		private int MoleMoleConfigTalkExecType_TypeID; // 0xC8
		private int MoleMoleConfigTalkExecType_EnumRef; // 0xCC
		private int MoleMoleConfigTalkBeginWay_TypeID; // 0xD0
		private int MoleMoleConfigTalkBeginWay_EnumRef; // 0xD4
		private int MoleMoleConfigTalkHeroType_TypeID; // 0xD8
		private int MoleMoleConfigTalkHeroType_EnumRef; // 0xDC
		private int MoleMoleConfigTalkLoadType_TypeID; // 0xE0
		private int MoleMoleConfigTalkLoadType_EnumRef; // 0xE4
		private int MoleMoleConfigTalkRoleType_TypeID; // 0xE8
		private int MoleMoleConfigTalkRoleType_EnumRef; // 0xEC
		private int MoleMoleConfigTalkShowType_TypeID; // 0xF0
		private int MoleMoleConfigTalkShowType_EnumRef; // 0xF4
		private int MoleMoleConfigTalkMarkType_TypeID; // 0xF8
		private int MoleMoleConfigTalkMarkType_EnumRef; // 0xFC
		private static XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj; // 0x08
		internal MethodWrapsCache methodWrapsCache; // 0x100
		internal ObjectCheckers objectCheckers; // 0x108
		internal ObjectCasters objectCasters; // 0x110
		internal readonly ObjectPool objects; // 0x118
		internal readonly Dictionary<object, int> reverseMap; // 0x120
		internal LuaEnv luaEnv; // 0x128
		internal StaticLuaCallbacks metaFunctions; // 0x130
		internal List<Assembly> assemblies; // 0x138
		private lua_CSFunction importTypeFunction; // 0x140
		private lua_CSFunction loadAssemblyFunction; // 0x148
		private lua_CSFunction castFunction; // 0x150
		private readonly Dictionary<System.Type, Action<IntPtr>> delayWrap; // 0x158
		private readonly Dictionary<System.Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators; // 0x160
		private readonly Dictionary<System.Type, System.Type> aliasCfg; // 0x168
		private Dictionary<System.Type, bool> loaded_types; // 0x170
		public int cacheRef; // 0x178
		private MethodInfo[] genericAction; // 0x180
		private MethodInfo[] genericFunc; // 0x188
		private Dictionary<System.Type, Func<DelegateBridgeBase, Delegate>> genericDelegateCreatorCache; // 0x190
		private Dictionary<int, WeakReference> delegate_bridges; // 0x198
		private int common_array_meta; // 0x1A0
		private int common_delegate_meta; // 0x1A4
		private int enumerable_pairs_func; // 0x1A8
		private Dictionary<System.Type, int> typeIdMap; // 0x1B0
		private Dictionary<int, System.Type> typeMap; // 0x1B8
		private HashSet<System.Type> privateAccessibleFlags; // 0x1C0
		private Dictionary<object, int> enumMap; // 0x1C8
		private List<lua_CSFunction> fix_cs_functions; // 0x1D0
		private Dictionary<System.Type, PushCSObject> custom_push_funcs; // 0x1D8
		private Dictionary<System.Type, GetCSObject> custom_get_funcs; // 0x1E0
		private Dictionary<System.Type, UpdateCSObject> custom_update_funcs; // 0x1E8
		private Dictionary<System.Type, Delegate> push_func_with_type; // 0x1F0
		private Dictionary<System.Type, Delegate> get_func_with_type; // 0x1F8
		private int decimal_type_id; // 0x200
	
		// Properties
		private static IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj { get => default; } // 0x0000000186148410-0x00000001861484A0 
		private static XLua_Gen_Initer_Register__ gen_reg_dumb_obj { get => default; } // 0x00000001861484A0-0x0000000186148530 
	
		// Nested types
		private class IniterAdderUnityEngineVector2 // TypeDefIndex: 32349
		{
			// Constructors
			static IniterAdderUnityEngineVector2() {} // 0x00000001866AFE60-0x00000001866AFF50
			public IniterAdderUnityEngineVector2() {} // 0x00000001866AFF50-0x00000001866AFFB0
	
			// Methods
			private static void Init(LuaEnv luaenv, ObjectTranslator translator) {} // 0x00000001866AE8E0-0x00000001866AFE60
		}
	
		internal enum LOGLEVEL // TypeDefIndex: 32350
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}
	
		public delegate void PushCSObject(IntPtr L, object obj); // TypeDefIndex: 32351; 0x00000001866B43B0-0x00000001866B4570
	
		public delegate object GetCSObject(IntPtr L, int idx); // TypeDefIndex: 32352; 0x00000001866AE6A0-0x00000001866AE860
	
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj); // TypeDefIndex: 32353; 0x00000001866C22D0-0x00000001866C24B0
	
		public delegate void GetFunc<T>(IntPtr L, int idx, out T val); // TypeDefIndex: 32354; 0x00000000-0x00000000
	
		// Constructors
		public ObjectTranslator() {} // Dummy constructor
		public ObjectTranslator(LuaEnv luaenv, IntPtr L) {} // 0x0000000186145F70-0x0000000186146770
		static ObjectTranslator() {} // 0x0000000186145EC0-0x0000000186145F70
	
		// Methods
		public void PushUnityEngineVector2(IntPtr L, Vector2 val) {} // 0x00000001861401A0-0x0000000186140330
		public void Get(IntPtr L, int index, out Vector2 val) {
			val = default;
		} // 0x0000000186136A30-0x0000000186136C50
		public void UpdateUnityEngineVector2(IntPtr L, int index, Vector2 val) {} // 0x00000001861456D0-0x00000001861458E0
		public void PushUnityEngineVector3(IntPtr L, Vector3 val) {} // 0x0000000186140330-0x00000001861404E0
		public void Get(IntPtr L, int index, out Vector3 val) {
			val = default;
		} // 0x0000000186136C50-0x0000000186136E70
		public void UpdateUnityEngineVector3(IntPtr L, int index, Vector3 val) {} // 0x00000001861458E0-0x0000000186145B00
		public void PushUnityEngineVector4(IntPtr L, Vector4 val) {} // 0x00000001861404E0-0x0000000186140680
		public void Get(IntPtr L, int index, out Vector4 val) {
			val = default;
		} // 0x0000000186136E70-0x0000000186137080
		public void UpdateUnityEngineVector4(IntPtr L, int index, Vector4 val) {} // 0x0000000186145B00-0x0000000186145D10
		public void PushUnityEngineColor(IntPtr L, Color val) {} // 0x000000018613FB00-0x000000018613FCA0
		public void Get(IntPtr L, int index, out Color val) {
			val = default;
		} // 0x0000000186136620-0x0000000186136830
		public void UpdateUnityEngineColor(IntPtr L, int index, Color val) {} // 0x0000000186144E70-0x0000000186145080
		public void PushUnityEngineQuaternion(IntPtr L, Quaternion val) {} // 0x000000018613FCA0-0x000000018613FE40
		public void Get(IntPtr L, int index, out Quaternion val) {
			val = default;
		} // 0x0000000186139110-0x0000000186139320
		public void UpdateUnityEngineQuaternion(IntPtr L, int index, Quaternion val) {} // 0x0000000186145080-0x0000000186145290
		public void PushUnityEngineRay(IntPtr L, Ray val) {} // 0x000000018613FFE0-0x00000001861401A0
		public void Get(IntPtr L, int index, out Ray val) {
			val = default;
		} // 0x0000000186137280-0x00000001861374A0
		public void UpdateUnityEngineRay(IntPtr L, int index, Ray val) {} // 0x00000001861454A0-0x00000001861456D0
		public void PushUnityEngineBounds(IntPtr L, Bounds val) {} // 0x000000018613F940-0x000000018613FB00
		public void Get(IntPtr L, int index, out Bounds val) {
			val = default;
		} // 0x0000000186139320-0x0000000186139540
		public void UpdateUnityEngineBounds(IntPtr L, int index, Bounds val) {} // 0x0000000186144C40-0x0000000186144E70
		public void PushUnityEngineRay2D(IntPtr L, Ray2D val) {} // 0x000000018613FE40-0x000000018613FFE0
		public void Get(IntPtr L, int index, out Ray2D val) {
			val = default;
		} // 0x0000000186139B40-0x0000000186139D50
		public void UpdateUnityEngineRay2D(IntPtr L, int index, Ray2D val) {} // 0x0000000186145290-0x00000001861454A0
		public void PushMoleMoleConfigRouteType(IntPtr L, RouteType val) {} // 0x000000018613DCE0-0x000000018613DF40
		public void Get(IntPtr L, int index, out RouteType val) {
			val = default;
		} // 0x0000000186136220-0x0000000186136420
		public void UpdateMoleMoleConfigRouteType(IntPtr L, int index, RouteType val) {} // 0x0000000186143640-0x0000000186143840
		public void PushMoleMoleConfigRotType(IntPtr L, RotType val) {} // 0x000000018613DA80-0x000000018613DCE0
		public void Get(IntPtr L, int index, out RotType val) {
			val = default;
		} // 0x0000000186137080-0x0000000186137280
		public void UpdateMoleMoleConfigRotType(IntPtr L, int index, RotType val) {} // 0x0000000186143440-0x0000000186143640
		public void PushMoleMoleConfigRotAngleType(IntPtr L, RotAngleType val) {} // 0x000000018613D820-0x000000018613DA80
		public void Get(IntPtr L, int index, out RotAngleType val) {
			val = default;
		} // 0x0000000186138CA0-0x0000000186138EA0
		public void UpdateMoleMoleConfigRotAngleType(IntPtr L, int index, RotAngleType val) {} // 0x0000000186143240-0x0000000186143440
		public void PushMoleMoleConfigActorType(IntPtr L, ActorType val) {} // 0x000000018613BB20-0x000000018613BD80
		public void Get(IntPtr L, int index, out ActorType val) {
			val = default;
		} // 0x0000000186136420-0x0000000186136620
		public void UpdateMoleMoleConfigActorType(IntPtr L, int index, ActorType val) {} // 0x0000000186141A40-0x0000000186141C40
		public void PushMoleMoleConfigTaskID(IntPtr L, TaskID val) {} // 0x000000018613F2C0-0x000000018613F520
		public void Get(IntPtr L, int index, out TaskID val) {
			val = default;
		} // 0x0000000186138AA0-0x0000000186138CA0
		public void UpdateMoleMoleConfigTaskID(IntPtr L, int index, TaskID val) {} // 0x0000000186144840-0x0000000186144A40
		public void PushMoleMoleConfigInterTimingType(IntPtr L, InterTimingType val) {} // 0x000000018613BD80-0x000000018613BFE0
		public void Get(IntPtr L, int index, out InterTimingType val) {
			val = default;
		} // 0x0000000186135E20-0x0000000186136020
		public void UpdateMoleMoleConfigInterTimingType(IntPtr L, int index, InterTimingType val) {} // 0x0000000186141C40-0x0000000186141E40
		public void PushMoleMoleConfigActorEvtTargetType(IntPtr L, ActorEvtTargetType val) {} // 0x000000018613B8C0-0x000000018613BB20
		public void Get(IntPtr L, int index, out ActorEvtTargetType val) {
			val = default;
		} // 0x00000001861388A0-0x0000000186138AA0
		public void UpdateMoleMoleConfigActorEvtTargetType(IntPtr L, int index, ActorEvtTargetType val) {} // 0x0000000186141840-0x0000000186141A40
		public void PushMoleMoleConfigWeatherType(IntPtr L, WeatherType val) {} // 0x000000018613F520-0x000000018613F780
		public void Get(IntPtr L, int index, out WeatherType val) {
			val = default;
		} // 0x0000000186135C20-0x0000000186135E20
		public void UpdateMoleMoleConfigWeatherType(IntPtr L, int index, WeatherType val) {} // 0x0000000186144A40-0x0000000186144C40
		public void PushMoleMoleConfigLuaTaskType(IntPtr L, LuaTaskType val) {} // 0x000000018613BFE0-0x000000018613C240
		public void Get(IntPtr L, int index, out LuaTaskType val) {
			val = default;
		} // 0x00000001861384A0-0x00000001861386A0
		public void UpdateMoleMoleConfigLuaTaskType(IntPtr L, int index, LuaTaskType val) {} // 0x0000000186141E40-0x0000000186142040
		public void PushMoleMoleConfigQuestType(IntPtr L, QuestType val) {} // 0x000000018613D5C0-0x000000018613D820
		public void Get(IntPtr L, int index, out QuestType val) {
			val = default;
		} // 0x0000000186136830-0x0000000186136A30
		public void UpdateMoleMoleConfigQuestType(IntPtr L, int index, QuestType val) {} // 0x0000000186143040-0x0000000186143240
		public void PushMoleMoleConfigQuestState(IntPtr L, QuestState val) {} // 0x000000018613D350-0x000000018613D5C0
		public void Get(IntPtr L, int index, out QuestState val) {
			val = default;
		} // 0x0000000186137CA0-0x0000000186137EA0
		public void UpdateMoleMoleConfigQuestState(IntPtr L, int index, QuestState val) {} // 0x0000000186142E40-0x0000000186143040
		public void PushMoleMoleConfigParentQuestState(IntPtr L, ParentQuestState val) {} // 0x000000018613C240-0x000000018613C4B0
		public void Get(IntPtr L, int index, out ParentQuestState val) {
			val = default;
		} // 0x0000000186135A20-0x0000000186135C20
		public void UpdateMoleMoleConfigParentQuestState(IntPtr L, int index, ParentQuestState val) {} // 0x0000000186142040-0x0000000186142240
		public void PushMoleMoleConfigQuestShowType(IntPtr L, QuestShowType val) {} // 0x000000018613D0E0-0x000000018613D350
		public void Get(IntPtr L, int index, out QuestShowType val) {
			val = default;
		} // 0x00000001861380A0-0x00000001861382A0
		public void UpdateMoleMoleConfigQuestShowType(IntPtr L, int index, QuestShowType val) {} // 0x0000000186142C40-0x0000000186142E40
		public void PushMoleMoleConfigQuestCondCompareType(IntPtr L, QuestCondCompareType val) {} // 0x000000018613C4B0-0x000000018613C720
		public void Get(IntPtr L, int index, out QuestCondCompareType val) {
			val = default;
		} // 0x0000000186136020-0x0000000186136220
		public void UpdateMoleMoleConfigQuestCondCompareType(IntPtr L, int index, QuestCondCompareType val) {} // 0x0000000186142240-0x0000000186142440
		public void PushMoleMoleConfigQuestCondType(IntPtr L, QuestCondType val) {} // 0x000000018613C720-0x000000018613C990
		public void Get(IntPtr L, int index, out QuestCondType val) {
			val = default;
		} // 0x0000000186139940-0x0000000186139B40
		public void UpdateMoleMoleConfigQuestCondType(IntPtr L, int index, QuestCondType val) {} // 0x0000000186142440-0x0000000186142640
		public void PushMoleMoleConfigQuestGuideType(IntPtr L, QuestGuideType val) {} // 0x000000018613CE70-0x000000018613D0E0
		public void Get(IntPtr L, int index, out QuestGuideType val) {
			val = default;
		} // 0x0000000186139D50-0x0000000186139F50
		public void UpdateMoleMoleConfigQuestGuideType(IntPtr L, int index, QuestGuideType val) {} // 0x0000000186142A40-0x0000000186142C40
		public void PushMoleMoleConfigQuestGuideNPCSelectType(IntPtr L, QuestGuideNPCSelectType val) {} // 0x000000018613CC00-0x000000018613CE70
		public void Get(IntPtr L, int index, out QuestGuideNPCSelectType val) {
			val = default;
		} // 0x0000000186139740-0x0000000186139940
		public void UpdateMoleMoleConfigQuestGuideNPCSelectType(IntPtr L, int index, QuestGuideNPCSelectType val) {} // 0x0000000186142840-0x0000000186142A40
		public void PushMoleMoleConfigShowQuestGuideType(IntPtr L, ShowQuestGuideType val) {} // 0x000000018613DF40-0x000000018613E1B0
		public void Get(IntPtr L, int index, out ShowQuestGuideType val) {
			val = default;
		} // 0x0000000186139540-0x0000000186139740
		public void UpdateMoleMoleConfigShowQuestGuideType(IntPtr L, int index, ShowQuestGuideType val) {} // 0x0000000186143840-0x0000000186143A40
		public void PushMoleMoleConfigQuestExecType(IntPtr L, QuestExecType val) {} // 0x000000018613C990-0x000000018613CC00
		public void Get(IntPtr L, int index, out QuestExecType val) {
			val = default;
		} // 0x00000001861374A0-0x00000001861376A0
		public void UpdateMoleMoleConfigQuestExecType(IntPtr L, int index, QuestExecType val) {} // 0x0000000186142640-0x0000000186142840
		public void PushMoleMoleConfigTalkExecType(IntPtr L, TalkExecType val) {} // 0x000000018613E420-0x000000018613E690
		public void Get(IntPtr L, int index, out TalkExecType val) {
			val = default;
		} // 0x00000001861382A0-0x00000001861384A0
		public void UpdateMoleMoleConfigTalkExecType(IntPtr L, int index, TalkExecType val) {} // 0x0000000186143C40-0x0000000186143E40
		public void PushMoleMoleConfigTalkBeginWay(IntPtr L, TalkBeginWay val) {} // 0x000000018613E1B0-0x000000018613E420
		public void Get(IntPtr L, int index, out TalkBeginWay val) {
			val = default;
		} // 0x00000001861386A0-0x00000001861388A0
		public void UpdateMoleMoleConfigTalkBeginWay(IntPtr L, int index, TalkBeginWay val) {} // 0x0000000186143A40-0x0000000186143C40
		public void PushMoleMoleConfigTalkHeroType(IntPtr L, TalkHeroType val) {} // 0x000000018613E690-0x000000018613E900
		public void Get(IntPtr L, int index, out TalkHeroType val) {
			val = default;
		} // 0x0000000186137AA0-0x0000000186137CA0
		public void UpdateMoleMoleConfigTalkHeroType(IntPtr L, int index, TalkHeroType val) {} // 0x0000000186143E40-0x0000000186144040
		public void PushMoleMoleConfigTalkLoadType(IntPtr L, TalkLoadType val) {} // 0x000000018613E900-0x000000018613EB70
		public void Get(IntPtr L, int index, out TalkLoadType val) {
			val = default;
		} // 0x00000001861376A0-0x00000001861378A0
		public void UpdateMoleMoleConfigTalkLoadType(IntPtr L, int index, TalkLoadType val) {} // 0x0000000186144040-0x0000000186144240
		public void PushMoleMoleConfigTalkRoleType(IntPtr L, TalkRoleType val) {} // 0x000000018613EDE0-0x000000018613F050
		public void Get(IntPtr L, int index, out TalkRoleType val) {
			val = default;
		} // 0x0000000186139F50-0x000000018613A150
		public void UpdateMoleMoleConfigTalkRoleType(IntPtr L, int index, TalkRoleType val) {} // 0x0000000186144440-0x0000000186144640
		public void PushMoleMoleConfigTalkShowType(IntPtr L, TalkShowType val) {} // 0x000000018613F050-0x000000018613F2C0
		public void Get(IntPtr L, int index, out TalkShowType val) {
			val = default;
		} // 0x0000000186137EA0-0x00000001861380A0
		public void UpdateMoleMoleConfigTalkShowType(IntPtr L, int index, TalkShowType val) {} // 0x0000000186144640-0x0000000186144840
		public void PushMoleMoleConfigTalkMarkType(IntPtr L, TalkMarkType val) {} // 0x000000018613EB70-0x000000018613EDE0
		public void Get(IntPtr L, int index, out TalkMarkType val) {
			val = default;
		} // 0x00000001861378A0-0x0000000186137AA0
		public void UpdateMoleMoleConfigTalkMarkType(IntPtr L, int index, TalkMarkType val) {} // 0x0000000186144240-0x0000000186144440
		public void DelayWrapLoader(System.Type type, Action<IntPtr> loader) {} // 0x0000000186134DC0-0x0000000186134E60
		public void AddInterfaceBridgeCreator(System.Type type, Func<int, LuaEnv, LuaBase> creator) {} // 0x0000000186133AC0-0x0000000186133B60
		public bool TryDelayWrapLoader(IntPtr L, System.Type type) => default; // 0x0000000186140ED0-0x0000000186141380
		public void Alias(System.Type type, string alias) {} // 0x0000000186133B60-0x0000000186133C70
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name) {} // 0x0000000186146770-0x0000000186146930
		private void initCSharpCallLua() {} // 0x0000000186148670-0x00000001861486C0
		private Delegate getDelegateUsingGeneric(DelegateBridgeBase bridge, System.Type delegateType, MethodInfo delegateMethod) => default; // 0x0000000186146F30-0x0000000186147AA0
		private Delegate getDelegate(DelegateBridgeBase bridge, System.Type delegateType) => default; // 0x0000000186147AA0-0x0000000186147E70
		public object CreateDelegateBridge(IntPtr L, System.Type delegateType, int idx) => default; // 0x0000000186134360-0x00000001861347B0
		public bool AllDelegateBridgeReleased() => default; // 0x0000000186133C70-0x0000000186133E20
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate) {} // 0x0000000186140B40-0x0000000186140CF0
		public object CreateInterfaceBridge(IntPtr L, System.Type interfaceType, int idx) => default; // 0x0000000186134C60-0x0000000186134DC0
		public void CreateArrayMetatable(IntPtr L) {} // 0x0000000186134030-0x0000000186134360
		public void CreateDelegateMetatable(IntPtr L) {} // 0x00000001861347B0-0x0000000186134B30
		internal void CreateEnumerablePairs(IntPtr L) {} // 0x0000000186134B30-0x0000000186134C60
		public void OpenLib(IntPtr L) {} // 0x000000018613AA00-0x000000018613B270
		internal void createFunctionMetatable(IntPtr L) {} // 0x0000000186146B80-0x0000000186146D60
		internal System.Type FindType(string className, bool isQualifiedName = false /* Metadata: 0x00B142D2 */) => default; // 0x0000000186134F00-0x0000000186135310
		private bool hasMethod(System.Type type, string methodName) => default; // 0x0000000186148530-0x0000000186148670
		internal void collectObject(int obj_index_to_collect) {} // 0x0000000186146A10-0x0000000186146B80
		private int addObject(object obj, bool is_valuetype, bool is_enum) => default; // 0x0000000186146930-0x0000000186146A10
		internal object GetObject(IntPtr L, int index) => default; // 0x0000000186135440-0x0000000186135540
		public System.Type GetTypeOf(IntPtr L, int idx) => default; // 0x0000000186135960-0x0000000186135A20
		public bool Assignable<T>(IntPtr L, int index) => default;
		public bool Assignable(IntPtr L, int index, System.Type type) => default; // 0x0000000186133E20-0x0000000186134030
		public object GetObject(IntPtr L, int index, System.Type type) => default; // 0x0000000186135540-0x00000001861357A0
		public void Get<T>(IntPtr L, int index, out T v) {
			v = default;
		}
		public void PushByType<T>(IntPtr L, T v) {}
		public T[] GetParams<T>(IntPtr L, int index) => default;
		public Array GetParams(IntPtr L, int index, System.Type type) => default; // 0x00000001861357A0-0x00000001861358C0
		public T GetDelegate<T>(IntPtr L, int index)
			where T : class => default;
		public int GetTypeId(IntPtr L, System.Type type) => default; // 0x00000001861358C0-0x0000000186135960
		public void PrivateAccessible(IntPtr L, System.Type type) {} // 0x000000018613B270-0x000000018613B360
		internal int getTypeId(IntPtr L, System.Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN /* Metadata: 0x00B142D3 */) {
			is_first = default;
			return default;
		} // 0x0000000186147E70-0x0000000186148410
		private void pushPrimitive(IntPtr L, object o) {} // 0x00000001861489D0-0x0000000186148D80
		public void PushAny(IntPtr L, object o) {} // 0x000000018613B360-0x000000018613B600
		public int TranslateToEnumToTop(IntPtr L, System.Type type, int idx) => default; // 0x0000000186140D90-0x0000000186140ED0
		public void Push(IntPtr L, lua_CSFunction o) {} // 0x00000001861408E0-0x00000001861409B0
		public void Push(IntPtr L, LuaBase o) {} // 0x00000001861409B0-0x0000000186140A40
		public void Push(IntPtr L, object o) {} // 0x0000000186140680-0x00000001861408E0
		public void PushObject(IntPtr L, object o, int type_id) {} // 0x000000018613F780-0x000000018613F940
		public void Update(IntPtr L, int index, object obj) {} // 0x0000000186145D10-0x0000000186145EC0
		private object getCsObj(IntPtr L, int index, int udata) => default; // 0x0000000186146D60-0x0000000186146F30
		internal object SafeGetCSObj(IntPtr L, int index) => default; // 0x0000000186140CF0-0x0000000186140D90
		internal object FastGetCSObj(IntPtr L, int index) => default; // 0x0000000186134E60-0x0000000186134F00
		internal void ReleaseCSObj(IntPtr L, int index) {} // 0x0000000186140A40-0x0000000186140B40
		internal lua_CSFunction GetFixCSFunction(int index) => default; // 0x00000001861353B0-0x0000000186135440
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func) {} // 0x000000018613B7B0-0x000000018613B8C0
		internal object[] popValues(IntPtr L, int oldTop) => default; // 0x00000001861486C0-0x0000000186148800
		internal object[] popValues(IntPtr L, int oldTop, System.Type[] popTypes) => default; // 0x0000000186148800-0x00000001861489D0
		private void registerCustomOp(System.Type type, PushCSObject push, GetCSObject get, UpdateCSObject update) {} // 0x0000000186148D80-0x0000000186148F10
		public bool HasCustomOp(System.Type type) => default; // 0x000000018613A150-0x000000018613A1E0
		private bool tryGetPushFuncByType<T>(System.Type type, out T func)
			where T : class {
			func = default;
			return default;
		}
		private bool tryGetGetFuncByType<T>(System.Type type, out T func)
			where T : class {
			func = default;
			return default;
		}
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update) {}
		public void RegisterCaster<T>(GetFunc<T> get) {}
		public void PushDecimal(IntPtr L, decimal val) {} // 0x000000018613B600-0x000000018613B7B0
		public bool IsDecimal(IntPtr L, int index) => default; // 0x000000018613A960-0x000000018613AA00
		public decimal GetDecimal(IntPtr L, int index) => default; // 0x0000000186135310-0x00000001861353B0
		public void Get(IntPtr L, int index, out decimal val) {
			val = default;
		} // 0x0000000186138EA0-0x0000000186139110
		public void InitCustomCasters() {} // 0x000000018613A1E0-0x000000018613A960
		public object ConfigDataCaster<T>(IntPtr L, int idx, object target) => default;
		public object LuaVirtualTypeCaster<T>(IntPtr L, int idx, object target) => default;
	}
}
