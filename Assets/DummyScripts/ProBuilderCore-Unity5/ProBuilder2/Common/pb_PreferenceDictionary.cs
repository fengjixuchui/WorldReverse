/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_PreferenceDictionary : ScriptableObject, IEnumerable, ISerializationCallbackReceiver, pb_IHasDefault // TypeDefIndex: 3420
	{
		// Fields
		private Dictionary<string, bool> m_Bool; // 0x18
		private Dictionary<string, int> m_Int; // 0x20
		private Dictionary<string, float> m_Float; // 0x28
		private Dictionary<string, string> m_String; // 0x30
		private Dictionary<string, Color> m_Color; // 0x38
		private Dictionary<string, UnityEngine.Material> m_Material; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_Bool_keys; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_Int_keys; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_Float_keys; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_String_keys; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_Color_keys; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_Material_keys; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<bool> m_Bool_values; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<int> m_Int_values; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<float> m_Float_values; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<string> m_String_values; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Color> m_Color_values; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<UnityEngine.Material> m_Material_values; // 0xA0
	
		// Properties
		public int Length { get => default; } // 0x0000000186BB6AD0-0x0000000186BB6B20 
	
		// Constructors
		public pb_PreferenceDictionary() {} // 0x0000000186BB6990-0x0000000186BB6AD0
	
		// Methods
		public void OnBeforeSerialize() {} // 0x0000000186BB5FF0-0x0000000186BB62C0
		public void OnAfterDeserialize() {} // 0x0000000186BB5B80-0x0000000186BB5FF0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000186BB6920-0x0000000186BB6990
		public pb_PreferenceDictionaryEnumerator GetEnumerator() => default; // 0x0000000186BB5570-0x0000000186BB55F0
		public void SetDefaultValues() {} // 0x0000000186BB6490-0x0000000186BB65A0
		public bool HasKey(string key) => default; // 0x0000000186BB5A30-0x0000000186BB5B80
		public bool HasKey<T>(string key) => default;
		public void DeleteKey(string key) {} // 0x0000000186BB5130-0x0000000186BB5330
		public T Get<T>(string key, T fallback = default) => default;
		public void Set<T>(string key, T value) {}
		public bool GetBool(string key, bool fallback = false /* Metadata: 0x00AC3CCF */) => default; // 0x0000000186BB5390-0x0000000186BB5440
		public int GetInt(string key, int fallback = 0 /* Metadata: 0x00AC3CD0 */) => default; // 0x0000000186BB5760-0x0000000186BB5810
		public float GetFloat(string key, float fallback = 0f /* Metadata: 0x00AC3CD4 */) => default; // 0x0000000186BB5650-0x0000000186BB5700
		public string GetString(string key, string fallback = null) => default; // 0x0000000186BB5980-0x0000000186BB5A30
		public Color GetColor(string key, Color fallback = default) => default; // 0x0000000186BB54A0-0x0000000186BB5570
		public UnityEngine.Material GetMaterial(string key, UnityEngine.Material fallback = null) => default; // 0x0000000186BB5870-0x0000000186BB5920
		public void SetBool(string key, bool value) {} // 0x0000000186BB62C0-0x0000000186BB63A0
		public void SetInt(string key, int value) {} // 0x0000000186BB6680-0x0000000186BB6760
		public void SetFloat(string key, float value) {} // 0x0000000186BB65A0-0x0000000186BB6680
		public void SetString(string key, string value) {} // 0x0000000186BB6840-0x0000000186BB6920
		public void SetColor(string key, Color value) {} // 0x0000000186BB63A0-0x0000000186BB6490
		public void SetMaterial(string key, UnityEngine.Material value) {} // 0x0000000186BB6760-0x0000000186BB6840
		public Dictionary<string, bool> GetBoolDictionary() => default; // 0x0000000186BB5330-0x0000000186BB5390
		public Dictionary<string, int> GetIntDictionary() => default; // 0x0000000186BB5700-0x0000000186BB5760
		public Dictionary<string, float> GetFloatDictionary() => default; // 0x0000000186BB55F0-0x0000000186BB5650
		public Dictionary<string, string> GetStringDictionary() => default; // 0x0000000186BB5920-0x0000000186BB5980
		public Dictionary<string, Color> GetColorDictionary() => default; // 0x0000000186BB5440-0x0000000186BB54A0
		public Dictionary<string, UnityEngine.Material> GetMaterialDictionary() => default; // 0x0000000186BB5810-0x0000000186BB5870
		public void Clear() {} // 0x0000000186BB5040-0x0000000186BB5130
	}
}
