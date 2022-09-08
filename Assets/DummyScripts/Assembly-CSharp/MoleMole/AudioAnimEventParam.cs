/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using Newtonsoft.Json.Linq;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public static class AudioAnimEventParam // TypeDefIndex: 10706
	{
		// Nested types
		private enum SolidConditionType // TypeDefIndex: 10707
		{
			True = 257,
			False = 258,
			BinaryAnd = 513,
			BinaryOr = 514,
			FloatEquals = 769,
			FloatGreater = 770,
			FloatLess = 771,
			FloatGreaterOrEqual = 772,
			FloatLessOrEqual = 773,
			IntEquals = 1025,
			IntGreater = 1026,
			IntLess = 1027,
			IntGreaterOrEqual = 1028,
			IntLessOrEqual = 1029,
			BoolTrue = 1281,
			BoolFalse = 1282,
			TriggerSet = 1537,
			TriggerUnset = 1538,
			UnaryNot = 1793
		}
	
		public abstract class Condition // TypeDefIndex: 10708
		{
			// Fields
			private static readonly HashSet<string> paramNameSet; // 0x00
	
			// Constructors
			static Condition() {} // 0x0000000182DD8060-0x0000000182DD8120
			protected Condition() {} // 0x0000000182DD8120-0x0000000182DD8340
	
			// Methods
			public abstract bool Holds(Animator animator);
			// [XID] // 0x0000000189877C60-0x0000000189877C80
			public virtual JObject ToJson() => default; // 0x0000000182DD7F00-0x0000000182DD8060
			// [XID] // 0x000000018987F4D0-0x000000018987F4F0
			public virtual JArray GetParamValues(Animator animator) => default; // 0x0000000182DD7CC0-0x0000000182DD7E30
			// [XID] // 0x0000000189886AE0-0x0000000189886B00
			public virtual void ProbeParameters(Animator animator, JArray json, HashSet<string> presentParams) {} // 0x0000000182DD7E30-0x0000000182DD7F00
			protected abstract void AddCustomJsonFields(JObject json);
		}
	
		public class True : Condition // TypeDefIndex: 10709
		{
			// Constructors
			public True() {} // 0x0000000182DDCDD0-0x0000000182DDCE90
	
			// Methods
			// [XID] // 0x000000018988DC30-0x000000018988DC50
			public override bool Holds(Animator animator) => default; // 0x0000000182DDCD20-0x0000000182DDCDD0
			// [XID] // 0x0000000189752FD0-0x0000000189752FF0
			protected override void AddCustomJsonFields(JObject json) {} // 0x0000000182DDCC40-0x0000000182DDCD20
		}
	
		public class False : Condition // TypeDefIndex: 10710
		{
			// Constructors
			public False() {} // 0x0000000182DD9650-0x0000000182DD9710
	
			// Methods
			// [XID] // 0x000000018989CA30-0x000000018989CA50
			public override bool Holds(Animator animator) => default; // 0x0000000182DD95A0-0x0000000182DD9650
			// [XID] // 0x00000001898A4260-0x00000001898A4280
			protected override void AddCustomJsonFields(JObject json) {} // 0x0000000182DD94C0-0x0000000182DD95A0
		}
	
		public abstract class Nested : Condition // TypeDefIndex: 10711
		{
			// Constructors
			protected Nested() {} // 0x0000000182DDAC30-0x0000000182DDAE70
		}
	
		public abstract class UniOp : Nested // TypeDefIndex: 10712
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private Condition _inner; // 0x10
	
			// Properties
			public Condition inner { /* [XID] */ /* 0x0000000189BA15D0-0x0000000189BA15F0 */ get; /* [XID] */ /* 0x00000001898BABE0-0x00000001898BAC00 */ set; } // 0x0000000182DDEC10-0x0000000182DDECB0 0x0000000182DDECB0-0x0000000182DDED60
	
			// Constructors
			protected UniOp() {} // 0x0000000182DDEBB0-0x0000000182DDEC10
		}
	
		public class UnaryNot : UniOp // TypeDefIndex: 10713
		{
			// Constructors
			public UnaryNot() {} // 0x0000000182DDEB10-0x0000000182DDEBB0
	
			// Methods
			// [XID] // 0x00000001898C1DF0-0x00000001898C1E10
			public override bool Holds(Animator animator) => default; // 0x0000000182DDE870-0x0000000182DDE960
			// [XID] // 0x00000001898C9810-0x00000001898C9830
			public override void ProbeParameters(Animator animator, JArray json, HashSet<string> presentParams) {} // 0x0000000182DDE960-0x0000000182DDEA80
			// [XID] // 0x00000001898D1000-0x00000001898D1020
			protected override void AddCustomJsonFields(JObject json) {} // 0x0000000182DDE730-0x0000000182DDE870
		}
	
		public abstract class BinOp : Nested // TypeDefIndex: 10714
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private Condition _left; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private Condition _right; // 0x18
	
			// Properties
			public Condition left { /* [XID] */ /* 0x00000001898E7FA0-0x00000001898E7FC0 */ get; /* [XID] */ /* 0x00000001898EF6F0-0x00000001898EF710 */ set; } // 0x0000000182DD6180-0x0000000182DD6220 0x0000000182DD62C0-0x0000000182DD6370
			public Condition right { /* [XID] */ /* 0x00000001898F6FF0-0x00000001898F7010 */ get; /* [XID] */ /* 0x00000001898FE780-0x00000001898FE7A0 */ set; } // 0x0000000182DD6220-0x0000000182DD62C0 0x0000000182DD6370-0x0000000182DD6420
	
			// Constructors
			protected BinOp() {} // 0x0000000182DD6120-0x0000000182DD6180
	
			// Methods
			// [XID] // 0x0000000189905E80-0x0000000189905EA0
			public override void ProbeParameters(Animator animator, JArray json, HashSet<string> presentParams) {} // 0x0000000182DD5F30-0x0000000182DD6090
			// [XID] // 0x000000018990D860-0x000000018990D880
			protected override void AddCustomJsonFields(JObject json) {} // 0x0000000182DD5D70-0x0000000182DD5F30
		}
	
		public class BinaryAnd : BinOp // TypeDefIndex: 10715
		{
			// Constructors
			public BinaryAnd() {} // 0x0000000182DD6560-0x0000000182DD6600
	
			// Methods
			// [XID] // 0x0000000189914F90-0x0000000189914FB0
			public override bool Holds(Animator animator) => default; // 0x0000000182DD6420-0x0000000182DD6560
		}
	
		public class BinaryOr : BinOp // TypeDefIndex: 10716
		{
			// Constructors
			public BinaryOr() {} // 0x0000000182DD6740-0x0000000182DD67E0
	
			// Methods
			// [XID] // 0x000000018960B120-0x000000018960B140
			public override bool Holds(Animator animator) => default; // 0x0000000182DD6600-0x0000000182DD6740
		}
	
		public abstract class ValueCond : Condition // TypeDefIndex: 10717
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _name; // 0x10
	
			// Properties
			public string parameterName { /* [XID] */ /* 0x000000018992B940-0x000000018992B960 */ get; /* [XID] */ /* 0x0000000189933080-0x00000001899330A0 */ set; } // 0x0000000182DDEE20-0x0000000182DDEEC0 0x0000000182DDEEC0-0x0000000182DDEF70
	
			// Constructors
			protected ValueCond() {} // 0x0000000182DDED60-0x0000000182DDEE20
		}
	
		public abstract class ValueCond<T> : ValueCond // TypeDefIndex: 10718
		{
			// Properties
			protected abstract string parameterType { get; }
	
			// Constructors
			protected ValueCond() {}
	
			// Methods
			public override bool Holds(Animator animator) => default;
			public override void ProbeParameters(Animator animator, JArray json, HashSet<string> presentParams) {}
			protected abstract T GetValue(Animator animator);
			protected abstract bool Holds(T value);
		}
	
		public interface ICompareValueCond // TypeDefIndex: 10719
		{
			// Methods
			float GetAsFloat();
			void SetFromFloat(float value);
		}
	
		public abstract class CompareValueCond<T> : ValueCond<T>, ICompareValueCond // TypeDefIndex: 10720
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private T _against;
	
			// Properties
			public T against { get; set; }
	
			// Constructors
			protected CompareValueCond() {}
	
			// Methods
			public abstract float GetAsFloat();
			public abstract void SetFromFloat(float value);
			protected override void AddCustomJsonFields(JObject json) {}
		}
	
		public abstract class FloatCond : CompareValueCond<float> // TypeDefIndex: 10721
		{
			// Properties
			protected override string parameterType { /* [XID] */ /* 0x0000000189612540-0x0000000189612560 */ get; } // 0x0000000182DD99D0-0x0000000182DD9A70 
	
			// Constructors
			protected FloatCond() {} // 0x0000000182DD9960-0x0000000182DD99D0
	
			// Methods
			// [XID] // 0x0000000189949550-0x0000000189949570
			public override float GetAsFloat() => default; // 0x0000000182DD9710-0x0000000182DD97D0
			// [XID] // 0x0000000189950DD0-0x0000000189950DF0
			public override void SetFromFloat(float value) {} // 0x0000000182DD98A0-0x0000000182DD9960
			// [XID] // 0x0000000189628BE0-0x0000000189628C00
			protected override float GetValue(Animator animator) => default; // 0x0000000182DD97D0-0x0000000182DD98A0
		}
	
		public class FloatEquals : FloatCond // TypeDefIndex: 10722
		{
			// Constructors
			public FloatEquals() {} // 0x0000000182DD9B40-0x0000000182DD9BF0
	
			// Methods
			// [XID] // 0x0000000189638110-0x0000000189638130
			protected override bool Holds(float value) => default; // 0x0000000182DD9A70-0x0000000182DD9B40
		}
	
		public class FloatGreater : FloatCond // TypeDefIndex: 10723
		{
			// Constructors
			public FloatGreater() {} // 0x0000000182DD9E20-0x0000000182DD9ED0
	
			// Methods
			// [XID] // 0x000000018963F370-0x000000018963F390
			protected override bool Holds(float value) => default; // 0x0000000182DD9D60-0x0000000182DD9E20
		}
	
		public class FloatLess : FloatCond // TypeDefIndex: 10724
		{
			// Constructors
			public FloatLess() {} // 0x0000000182DDA100-0x0000000182DDA1B0
	
			// Methods
			// [XID] // 0x000000018996E760-0x000000018996E780
			protected override bool Holds(float value) => default; // 0x0000000182DDA040-0x0000000182DDA100
		}
	
		public class FloatGreaterOrEqual : FloatCond // TypeDefIndex: 10725
		{
			// Constructors
			public FloatGreaterOrEqual() {} // 0x0000000182DD9CB0-0x0000000182DD9D60
	
			// Methods
			// [XID] // 0x000000018964E460-0x000000018964E480
			protected override bool Holds(float value) => default; // 0x0000000182DD9BF0-0x0000000182DD9CB0
		}
	
		public class FloatLessOrEqual : FloatCond // TypeDefIndex: 10726
		{
			// Constructors
			public FloatLessOrEqual() {} // 0x0000000182DD9F90-0x0000000182DDA040
	
			// Methods
			// [XID] // 0x000000018997D600-0x000000018997D620
			protected override bool Holds(float value) => default; // 0x0000000182DD9ED0-0x0000000182DD9F90
		}
	
		public abstract class IntCond : CompareValueCond<int> // TypeDefIndex: 10727
		{
			// Properties
			protected override string parameterType { /* [XID] */ /* 0x00000001899851C0-0x00000001899851E0 */ get; } // 0x0000000182DDA460-0x0000000182DDA500 
	
			// Constructors
			protected IntCond() {} // 0x0000000182DDA3F0-0x0000000182DDA460
	
			// Methods
			// [XID] // 0x000000018966AB80-0x000000018966ABA0
			public override float GetAsFloat() => default; // 0x0000000182DDA1B0-0x0000000182DDA270
			// [XID] // 0x0000000189994980-0x00000001899949A0
			public override void SetFromFloat(float value) {} // 0x0000000182DDA330-0x0000000182DDA3F0
			// [XID] // 0x000000018967A0C0-0x000000018967A0E0
			protected override int GetValue(Animator animator) => default; // 0x0000000182DDA270-0x0000000182DDA330
		}
	
		public class IntEquals : IntCond // TypeDefIndex: 10728
		{
			// Constructors
			public IntEquals() {} // 0x0000000182DDA5C0-0x0000000182DDA670
	
			// Methods
			// [XID] // 0x0000000189689220-0x0000000189689240
			protected override bool Holds(int value) => default; // 0x0000000182DDA500-0x0000000182DDA5C0
		}
	
		public class IntGreater : IntCond // TypeDefIndex: 10729
		{
			// Constructors
			public IntGreater() {} // 0x0000000182DDA8A0-0x0000000182DDA950
	
			// Methods
			// [XID] // 0x00000001899AB690-0x00000001899AB6B0
			protected override bool Holds(int value) => default; // 0x0000000182DDA7E0-0x0000000182DDA8A0
		}
	
		public class IntLess : IntCond // TypeDefIndex: 10730
		{
			// Constructors
			public IntLess() {} // 0x0000000182DDAB80-0x0000000182DDAC30
	
			// Methods
			// [XID] // 0x00000001899B3010-0x00000001899B3030
			protected override bool Holds(int value) => default; // 0x0000000182DDAAC0-0x0000000182DDAB80
		}
	
		public class IntGreaterOrEqual : IntCond // TypeDefIndex: 10731
		{
			// Constructors
			public IntGreaterOrEqual() {} // 0x0000000182DDA730-0x0000000182DDA7E0
	
			// Methods
			// [XID] // 0x00000001899BA1B0-0x00000001899BA1D0
			protected override bool Holds(int value) => default; // 0x0000000182DDA670-0x0000000182DDA730
		}
	
		public class IntLessOrEqual : IntCond // TypeDefIndex: 10732
		{
			// Constructors
			public IntLessOrEqual() {} // 0x0000000182DDAA10-0x0000000182DDAAC0
	
			// Methods
			// [XID] // 0x00000001896A6CA0-0x00000001896A6CC0
			protected override bool Holds(int value) => default; // 0x0000000182DDA950-0x0000000182DDAA10
		}
	
		public abstract class BoolCond : ValueCond<bool> // TypeDefIndex: 10733
		{
			// Properties
			protected abstract bool flag { get; }
			protected override string parameterType { /* [XID] */ /* 0x00000001899D0D10-0x00000001899D0D30 */ get; } // 0x0000000182DD6A70-0x0000000182DD6B10 
	
			// Constructors
			protected BoolCond() {} // 0x0000000182DD6A00-0x0000000182DD6A70
	
			// Methods
			// [XID] // 0x00000001899C9160-0x00000001899C9180
			protected override bool GetValue(Animator animator) => default; // 0x0000000182DD6930-0x0000000182DD6A00
			// [XID] // 0x00000001899D8070-0x00000001899D8090
			protected override void AddCustomJsonFields(JObject json) {} // 0x0000000182DD67E0-0x0000000182DD6930
		}
	
		public class BoolTrue : BoolCond // TypeDefIndex: 10734
		{
			// Properties
			protected override bool flag { /* [XID] */ /* 0x00000001896D2C50-0x00000001896D2C70 */ get => default; } // 0x0000000182DD6E70-0x0000000182DD6F10 
	
			// Constructors
			public BoolTrue() {} // 0x0000000182DD6DC0-0x0000000182DD6E70
	
			// Methods
			// [XID] // 0x00000001899DF680-0x00000001899DF6A0
			protected override bool Holds(bool value) => default; // 0x0000000182DD6D10-0x0000000182DD6DC0
		}
	
		public class BoolFalse : BoolCond // TypeDefIndex: 10735
		{
			// Properties
			protected override bool flag { /* [XID] */ /* 0x00000001899F5EC0-0x00000001899F5EE0 */ get => default; } // 0x0000000182DD6C70-0x0000000182DD6D10 
	
			// Constructors
			public BoolFalse() {} // 0x0000000182DD6BC0-0x0000000182DD6C70
	
			// Methods
			// [XID] // 0x00000001899EE650-0x00000001899EE670
			protected override bool Holds(bool value) => default; // 0x0000000182DD6B10-0x0000000182DD6BC0
		}
	
		public abstract class TriggerCond : ValueCond<bool> // TypeDefIndex: 10736
		{
			// Properties
			protected abstract string state { get; }
			protected override string parameterType { /* [XID] */ /* 0x0000000189A04CC0-0x0000000189A04CE0 */ get; } // 0x0000000182DDC7A0-0x0000000182DDC840 
	
			// Constructors
			protected TriggerCond() {} // 0x0000000182DDC730-0x0000000182DDC7A0
	
			// Methods
			// [XID] // 0x00000001899FD5B0-0x00000001899FD5D0
			protected override bool GetValue(Animator animator) => default; // 0x0000000182DDC660-0x0000000182DDC730
			// [XID] // 0x0000000189A0C330-0x0000000189A0C350
			protected override void AddCustomJsonFields(JObject json) {} // 0x0000000182DDC510-0x0000000182DDC660
		}
	
		public class TriggerSet : TriggerCond // TypeDefIndex: 10737
		{
			// Properties
			protected override string state { /* [XID] */ /* 0x0000000189A1AED0-0x0000000189A1AEF0 */ get => default; } // 0x0000000182DDC9A0-0x0000000182DDCA40 
	
			// Constructors
			public TriggerSet() {} // 0x0000000182DDC8F0-0x0000000182DDC9A0
	
			// Methods
			// [XID] // 0x00000001897CB6E0-0x00000001897CB700
			protected override bool Holds(bool value) => default; // 0x0000000182DDC840-0x0000000182DDC8F0
		}
	
		public class TriggerUnset : TriggerCond // TypeDefIndex: 10738
		{
			// Properties
			protected override string state { /* [XID] */ /* 0x0000000189A29AA0-0x0000000189A29AC0 */ get => default; } // 0x0000000182DDCBA0-0x0000000182DDCC40 
	
			// Constructors
			public TriggerUnset() {} // 0x0000000182DDCAF0-0x0000000182DDCBA0
	
			// Methods
			// [XID] // 0x0000000189A22860-0x0000000189A22880
			protected override bool Holds(bool value) => default; // 0x0000000182DDCA40-0x0000000182DDCAF0
		}
	
		// Methods
		// [IDTag] // 0x000000018980EF00-0x000000018980EF40
		// [XID] // 0x000000018980EF00-0x000000018980EF40
		public static Condition CreateInstance(System.Type type) => default; // 0x0000000182DBE2A0-0x0000000182DBE360
		// [IDTag] // 0x0000000189819A90-0x0000000189819AD0
		// [XID] // 0x0000000189819A90-0x0000000189819AD0
		public static Condition CreateInstance(string typeName) => default; // 0x0000000182DBE360-0x0000000182DBE4B0
		// [XID] // 0x0000000189823C00-0x0000000189823C20
		public static void Serialize(Condition condition, out string[] names, out float[] conds) {
			names = default;
			conds = default;
		} // 0x0000000182DBEA80-0x0000000182DBF0A0
		// [IDTag] // 0x000000018982B5B0-0x000000018982B5F0
		// [XID] // 0x000000018982B5B0-0x000000018982B5F0
		public static Condition Deserialize(string[] names, float[] conds) => default; // 0x0000000182DBE7A0-0x0000000182DBE860
		// [XID] // 0x0000000189835A90-0x0000000189835AB0
		private static Condition[] Flatten(Condition condition) => default; // 0x0000000182DBE860-0x0000000182DBEA80
		// [XID] // 0x000000018983D180-0x000000018983D1A0
		private static string[] CollectNames(Condition[] conds) => default; // 0x0000000182DBDC80-0x0000000182DBDF10
		// [IDTag] // 0x0000000189844910-0x0000000189844950
		// [XID] // 0x0000000189844910-0x0000000189844950
		private static Condition Deserialize(string[] names, float[] conds, int index) => default; // 0x0000000182DBE4B0-0x0000000182DBE7A0
		// [IDTag] // 0x000000018984ED00-0x000000018984ED40
		// [XID] // 0x000000018984ED00-0x000000018984ED40
		private static Condition CreateInstance(SolidConditionType type) => default; // 0x0000000182DBDF10-0x0000000182DBE2A0
	}
}
