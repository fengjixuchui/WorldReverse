/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DynamicFloat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14788
{
	// Fields
	private BaseValue _dynamicValue; // 0x10
	private static Dictionary<float, DynamicFloat> _defaultValueDict; // 0x00

	// Nested types
	public interface BaseValue // TypeDefIndex: 14789
	{
		// Methods
		float GetValue(ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin);
		void ObjectContentHashOnto(ref int hash);
		void ToBinary(ByteArray byteArray);
	}

	public struct OperatorValue : BaseValue // TypeDefIndex: 14790
	{
		// Properties
		public Operator op { /* [XID] */ /* 0x0000000189716B20-0x0000000189716B60 */ get; private set; } // 0x0000000184904420-0x0000000184904550 0x0000000184904230-0x0000000184904290

		// Nested types
		public enum Operator // TypeDefIndex: 14791
		{
			Add = 0,
			Sub = 1,
			Mul = 11,
			Div = 12
		}

		// Constructors
		public OperatorValue(char c) : this() {} // 0x0000000184904A10-0x0000000184904B10
		public OperatorValue(ByteArray byteArray, int threadFlag) : this() {} // 0x0000000184904B10-0x0000000184904C70

		// Methods
		// [XID] // 0x00000001897289F0-0x0000000189728A10
		public void ToBinary(ByteArray byteArray) {} // 0x0000000184903C70-0x0000000184903D10
		// [XID] // 0x0000000189730220-0x0000000189730240
		public float GetValue(ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin) => default; // 0x0000000184904550-0x0000000184904720
		// [XID] // 0x0000000189737C00-0x0000000189737C20
		public float Calculate(float lValue, float rValue) => default; // 0x0000000184904720-0x00000001849048D0
		// [XID] // 0x000000018973F780-0x000000018973F7A0
		public override string ToString() => default; // 0x00000001849048D0-0x0000000184904A10
		// [XID] // 0x0000000189746AE0-0x0000000189746B00
		public void ObjectContentHashOnto(ref int hash) {} // 0x0000000184903F60-0x0000000184903F70
		// [XID] // 0x000000018974E490-0x000000018974E4B0
		public static bool operator <(OperatorValue lop, OperatorValue rop) => default; // 0x0000000184903F70-0x00000001849040A0
		// [XID] // 0x0000000189755B10-0x0000000189755B30
		public static bool operator >(OperatorValue lop, OperatorValue rop) => default; // 0x0000000184903D20-0x0000000184903F60
		// [XID] // 0x000000018975CDF0-0x000000018975CE10
		public static bool operator <=(OperatorValue lop, OperatorValue rop) => default; // 0x0000000184904290-0x0000000184904420
		// [XID] // 0x0000000189764660-0x0000000189764680
		public static bool operator >=(OperatorValue lop, OperatorValue rop) => default; // 0x00000001849040A0-0x0000000184904230
	}

	public struct SingleValue : BaseValue // TypeDefIndex: 14792
	{
		// Fields
		private bool _isDynamic; // 0x00
		private string _dynamicKey; // 0x08
		private SimpleSafeFloat _fixedValue; // 0x10

		// Constructors
		public SingleValue(string key) {
			_isDynamic = default;
			_dynamicKey = default;
			_fixedValue = default;
		} // 0x00000001849051F0-0x0000000184905360
		public SingleValue(float value) {
			_isDynamic = default;
			_dynamicKey = default;
			_fixedValue = default;
		} // 0x0000000184905140-0x00000001849051F0
		public SingleValue(ByteArray byteArray, int threadFlag) {
			_isDynamic = default;
			_dynamicKey = default;
			_fixedValue = default;
		} // 0x0000000184905360-0x00000001849053F0

		// Methods
		// [XID] // 0x000000018976BF40-0x000000018976BF60
		public void ToBinary(ByteArray byteArray) {} // 0x0000000184904C70-0x0000000184904D20
		// [XID] // 0x0000000189773400-0x0000000189773420
		public float GetValue(ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin) => default; // 0x0000000184904F90-0x0000000184905090
		// [XID] // 0x000000018977AB00-0x000000018977AB20
		public override string ToString() => default; // 0x0000000184905090-0x0000000184905140
		// [XID] // 0x00000001897826E0-0x0000000189782700
		public void ObjectContentHashOnto(ref int hash) {} // 0x0000000184904E60-0x0000000184904F90
	}

	public struct FormulaValue : BaseValue // TypeDefIndex: 14793
	{
		// Fields
		public static readonly Regex regex; // 0x00
		private BaseValue[] _values; // 0x00
		private Func<BaseValue[], ActorAbility, ActorAbilityPlugin, float> _formatCalculator; // 0x08
		private static Func<BaseValue[], ActorAbility, ActorAbilityPlugin, float> AMulBCalculator; // 0x08
		private static Func<BaseValue[], ActorAbility, ActorAbilityPlugin, float> AAddBCalculator; // 0x10
		private static Func<BaseValue[], ActorAbility, ActorAbilityPlugin, float> AMulBAddCCalculator; // 0x18

		// Constructors
		public FormulaValue(string str) {
			_values = default;
			_formatCalculator = default;
		} // 0x00000001849261B0-0x00000001849261E0
		public FormulaValue(ByteArray byteArray, int threadFlag) {
			_values = default;
			_formatCalculator = default;
		} // 0x0000000184925B50-0x00000001849261B0
		static FormulaValue() {
			regex = default;
			AMulBCalculator = default;
			AAddBCalculator = default;
			AMulBAddCCalculator = default;
		} // 0x0000000184925740-0x0000000184925B50

		// Methods
		// [XID] // 0x00000001897A07D0-0x00000001897A07F0
		public void ToBinary(ByteArray byteArray) {} // 0x0000000184924470-0x0000000184924480
		// [XID] // 0x00000001897A7D80-0x00000001897A7DA0
		public float GetValue(ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin) => default; // 0x0000000184924F80-0x0000000184925410
		// [XID] // 0x00000001897AF870-0x00000001897AF890
		public override string ToString() => default; // 0x0000000184925730-0x0000000184925740
		// [XID] // 0x00000001897B76B0-0x00000001897B76D0
		public void ObjectContentHashOnto(ref int hash) {} // 0x0000000184924880-0x0000000184924990
		// [XID] // 0x00000001897BF5B0-0x00000001897BF5D0
		private void CheckFormat() {} // 0x0000000184925410-0x0000000184925420
		// [XID] // 0x00000001897C6C80-0x00000001897C6CA0
		private bool TryFormat(ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin, ref float value) => default; // 0x0000000184924990-0x00000001849249A0
		// [XID] // 0x00000001897CE400-0x00000001897CE420
		private static float AMulB(BaseValue[] values, ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin) => default; // 0x0000000184925420-0x0000000184925730
		// [XID] // 0x00000001897D5990-0x00000001897D59B0
		private static float AAddB(BaseValue[] values, ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin) => default; // 0x00000001849249A0-0x0000000184924F80
		// [XID] // 0x00000001897DD070-0x00000001897DD090
		private static float AMulBAddC(BaseValue[] values, ActorAbility ability, ActorAbilityPlugin sourceAbilityPlugin) => default; // 0x0000000184924480-0x00000001849246C0
	}

	// Constructors
	public DynamicFloat(float value) {} // 0x000000018491E890-0x000000018491E9D0
	public DynamicFloat() {} // 0x000000018491E9D0-0x000000018491EA30
	static DynamicFloat() {} // 0x000000018491E800-0x000000018491E890

	// Methods
	// [XID] // 0x00000001897842F0-0x0000000189784310
	public float GetValue(ActorAbility ability = null, ActorAbilityPlugin sourceAbilityPlugin = null) => default; // 0x000000018491E280-0x000000018491E370
	// [XID] // 0x000000018968EE30-0x000000018968EE50
	public override string ToString() => default; // 0x000000018491E710-0x000000018491E800
	// [XID] // 0x00000001896967D0-0x00000001896967F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018491E370-0x000000018491E440
	// [XID] // 0x0000000189A26C20-0x0000000189A26C40
	public bool FromJson(JSONNode node) => default; // 0x000000018491DD20-0x000000018491E030
	// [XID] // 0x00000001896A4E60-0x00000001896A4E80
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018491D8F0-0x000000018491DA20
	// [XID] // 0x00000001896AC730-0x00000001896AC750
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5AB */, bool useObjectPool = false /* Metadata: 0x00AEF5AF */) => default; // 0x000000018491E0D0-0x000000018491E280
	// [XID] // 0x00000001896B3A50-0x00000001896B3A70
	public static implicit operator DynamicFloat(float fixedValue) => default; // 0x000000018491D520-0x000000018491D8F0
	// [XID] // 0x00000001896BB150-0x00000001896BB170
	public static bool IsDefaultValue(DynamicFloat value) => default; // 0x000000018491E580-0x000000018491E670
	// [XID] // 0x00000001896C22C0-0x00000001896C22E0
	public void Copy(DynamicFloat other) {} // 0x000000018491DC70-0x000000018491DD20
	// [XID] // 0x00000001896C9890-0x00000001896C98B0
	public void Reset() {} // 0x000000018491DBD0-0x000000018491DC70
	// [XID] // 0x00000001896D1000-0x00000001896D1020
	public void InitEmpty() {} // 0x000000018491E030-0x000000018491E0D0
	[BlackList] // 0x00000001896D8710-0x00000001896D8750
	// [XID] // 0x00000001896D8710-0x00000001896D8750
	public virtual void AutoAllocTypeFields() {} // 0x000000018491DA20-0x000000018491DAC0
	[BlackList] // 0x00000001896E2DC0-0x00000001896E2E00
	// [XID] // 0x00000001896E2DC0-0x00000001896E2E00
	public virtual void AutoRecycleTypeFields() {} // 0x000000018491DAC0-0x000000018491DB60
	[BlackList] // 0x00000001896ED0E0-0x00000001896ED120
	// [XID] // 0x00000001896ED0E0-0x00000001896ED120
	public virtual void ReturnToObjectPool() {} // 0x000000018491E670-0x000000018491E710
	[BlackList] // 0x00000001896F7850-0x00000001896F7890
	// [XID] // 0x00000001896F7850-0x00000001896F7890
	public virtual void OnPoolAllocated() {} // 0x000000018491E4E0-0x000000018491E580
	[BlackList] // 0x0000000189701F20-0x0000000189701F60
	// [XID] // 0x0000000189701F20-0x0000000189701F60
	public virtual void OnBeforePoolRecycled() {} // 0x000000018491E440-0x000000018491E4E0
}

