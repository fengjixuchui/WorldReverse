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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MonoEffectProxy : IWorldShiftAgent // TypeDefIndex: 19752
{
	// Fields
	private MonoEffect _monoEffect; // 0x10
	private readonly bool _asyncLoad; // 0x18
	private readonly string _effectName; // 0x20
	private readonly uint _runtimeID; // 0x28
	private bool _hasAttached; // 0x2C
	private bool _effectLoaded; // 0x2D
	private Queue<MonoEffectCmdBase> _commandQueue; // 0x30
	private uint _ownerID; // 0x38

	// Properties
	public bool IsInvalid { /* [XID] */ /* 0x0000000189803CD0-0x0000000189803CF0 */ get => default; } // 0x0000000181CF86B0-0x0000000181CF87B0 
	public bool effectIsNull { /* [XID] */ /* 0x000000018980B1B0-0x000000018980B1D0 */ get => default; } // 0x0000000181CF9470-0x0000000181CF9540 
	public uint runtimeID { /* [XID] */ /* 0x0000000189A8B8F0-0x0000000189A8B910 */ get => default; } // 0x0000000181CF8050-0x0000000181CF80F0 
	public string effectName { /* [XID] */ /* 0x000000018981A480-0x000000018981A4A0 */ get => default; } // 0x0000000181CF9660-0x0000000181CF9700 
	public uint ownerID { /* [XID] */ /* 0x00000001897F71A0-0x00000001897F71C0 */ get => default; } // 0x0000000181CF9060-0x0000000181CF9100 

	// Nested types
	private abstract class MonoEffectCmdBase // TypeDefIndex: 19753
	{
		// Properties
		public virtual bool isCustomCommand { /* [XID] */ /* 0x0000000189830650-0x0000000189830670 */ get; } // 0x0000000181CE5D00-0x0000000181CE5DA0 

		// Constructors
		protected MonoEffectCmdBase() {} // 0x0000000181CE5DA0-0x0000000181CE5E00

		// Methods
		public abstract void InvokeCommand(MonoEffect monoEffect);
	}

	private class CmdCustomCommand : MonoEffectCmdBase // TypeDefIndex: 19754
	{
		// Fields
		private Action<MonoEffect> _customCommand; // 0x10

		// Properties
		public override bool isCustomCommand { /* [XID] */ /* 0x000000018983F410-0x000000018983F430 */ get => default; } // 0x0000000181CE5160-0x0000000181CE5200 

		// Constructors
		public CmdCustomCommand() {} // 0x0000000181CE53E0-0x0000000181CE5480

		// Methods
		// [XID] // 0x0000000189837C10-0x0000000189837C30
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE5320-0x0000000181CE53E0
		// [XID] // 0x0000000189846AB0-0x0000000189846AD0
		public void Init(Action<MonoEffect> customCommand) {} // 0x0000000181CE5200-0x0000000181CE52B0
	}

	private class CmdSetMonoEffectPluginAnimatorPose : MonoEffectCmdBase // TypeDefIndex: 19755
	{
		// Fields
		private bool _effectNameEmpty; // 0x10
		private string _effectName; // 0x18
		private string _parameter; // 0x20
		private AnimatorParamType _type; // 0x28
		private int _value; // 0x2C

		// Constructors
		public CmdSetMonoEffectPluginAnimatorPose() {} // 0x0000000181CE6020-0x0000000181CE60C0

		// Methods
		// [XID] // 0x000000018984E0A0-0x000000018984E0C0
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE5F10-0x0000000181CE6020
		// [XID] // 0x0000000189855170-0x0000000189855190
		public void Init(bool effectNameEmpty, string effectName, string parameter, AnimatorParamType type, int value) {} // 0x0000000181CE5E00-0x0000000181CE5F10
	}

	private class CmdSetEffectActive : MonoEffectCmdBase // TypeDefIndex: 19756
	{
		// Fields
		private bool _active; // 0x10
		private bool _checkOwner; // 0x11

		// Constructors
		public CmdSetEffectActive() {} // 0x0000000181D09250-0x0000000181D092F0

		// Methods
		// [XID] // 0x000000018985C850-0x000000018985C870
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181D09150-0x0000000181D09250
		// [XID] // 0x0000000189864170-0x0000000189864190
		public void Init(bool active, bool checkOwner) {} // 0x0000000181D09080-0x0000000181D09150
	}

	private class CmdSetEffectStop : MonoEffectCmdBase // TypeDefIndex: 19757
	{
		// Constructors
		public CmdSetEffectStop() {} // 0x0000000181CE6250-0x0000000181CE62F0

		// Methods
		// [XID] // 0x000000018986B560-0x000000018986B580
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE6160-0x0000000181CE6250
		// [XID] // 0x0000000189AF99F0-0x0000000189AF9A10
		public void Init() {} // 0x0000000181CE60C0-0x0000000181CE6160
	}

	private class CmdSetVisible : MonoEffectCmdBase // TypeDefIndex: 19758
	{
		// Fields
		private bool _enable; // 0x10

		// Constructors
		public CmdSetVisible() {} // 0x0000000181D08A50-0x0000000181D08AF0

		// Methods
		// [XID] // 0x000000018987A580-0x000000018987A5A0
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181D08950-0x0000000181D08A50
		// [XID] // 0x00000001898816E0-0x0000000189881700
		public void Init(bool enable) {} // 0x0000000181D088A0-0x0000000181D08950
	}

	private class CmdSetEffectDeallocate : MonoEffectCmdBase // TypeDefIndex: 19759
	{
		// Constructors
		public CmdSetEffectDeallocate() {} // 0x0000000181D09480-0x0000000181D095C0

		// Methods
		// [XID] // 0x0000000189888C20-0x0000000189888C40
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181D09390-0x0000000181D09480
		// [XID] // 0x0000000189A5B060-0x0000000189A5B080
		public void Init() {} // 0x0000000181D092F0-0x0000000181D09390
	}

	private class CmdSetPosition : MonoEffectCmdBase // TypeDefIndex: 19760
	{
		// Fields
		private Vector3 _position; // 0x10

		// Constructors
		public CmdSetPosition() {} // 0x0000000181D08800-0x0000000181D088A0

		// Methods
		// [XID] // 0x0000000189897520-0x0000000189897540
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181D08630-0x0000000181D08800
		// [XID] // 0x000000018989EA40-0x000000018989EA60
		public void Init(Vector3 position) {} // 0x0000000181D08560-0x0000000181D08630
	}

	private class CmdSetForward : MonoEffectCmdBase // TypeDefIndex: 19761
	{
		// Fields
		private Vector3 _forward; // 0x10

		// Constructors
		public CmdSetForward() {} // 0x0000000181D08D30-0x0000000181D08DD0

		// Methods
		// [XID] // 0x00000001898A64E0-0x00000001898A6500
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181D08BC0-0x0000000181D08D30
		// [XID] // 0x00000001898ADC30-0x00000001898ADC50
		public void Init(Vector3 forward) {} // 0x0000000181D08AF0-0x0000000181D08BC0
	}

	private class CmdSetPositionAndRotation : MonoEffectCmdBase // TypeDefIndex: 19762
	{
		// Fields
		private Vector3 _position; // 0x10
		private Quaternion _rotation; // 0x1C

		// Constructors
		public CmdSetPositionAndRotation() {} // 0x0000000181CE5C60-0x0000000181CE5D00

		// Methods
		// [XID] // 0x00000001898B50E0-0x00000001898B5100
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE5A80-0x0000000181CE5C60
		// [XID] // 0x00000001898BCBF0-0x00000001898BCC10
		public void Init(Vector3 position, Quaternion rotation) {} // 0x0000000181CE5990-0x0000000181CE5A80
	}

	private class CmdStopShaderFadePlugin : MonoEffectCmdBase // TypeDefIndex: 19763
	{
		// Constructors
		public CmdStopShaderFadePlugin() {} // 0x0000000181CE5670-0x0000000181CE5710

		// Methods
		// [XID] // 0x00000001898C4360-0x00000001898C4380
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE5520-0x0000000181CE5670
		// [XID] // 0x00000001898CB930-0x00000001898CB950
		public void Init() {} // 0x0000000181CE5480-0x0000000181CE5520
	}

	private class CmdSetMonoEffectAnimatorParamFloat : MonoEffectCmdBase // TypeDefIndex: 19764
	{
		// Fields
		private string _effectName; // 0x10
		private int _id; // 0x18
		private float _value; // 0x1C

		// Constructors
		public CmdSetMonoEffectAnimatorParamFloat() {} // 0x0000000181CE50C0-0x0000000181CE5160

		// Methods
		// [XID] // 0x00000001898D30B0-0x00000001898D30D0
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE4FC0-0x0000000181CE50C0
		// [XID] // 0x00000001898DA9C0-0x00000001898DA9E0
		public void Init(string effectName, int id, float value) {} // 0x0000000181CE4EE0-0x0000000181CE4FC0
	}

	private class CmdApplyEffectArgsTemplate : MonoEffectCmdBase // TypeDefIndex: 19765
	{
		// Fields
		private int _templateID; // 0x10

		// Constructors
		public CmdApplyEffectArgsTemplate() {} // 0x0000000181CE6490-0x0000000181CE6530

		// Methods
		// [XID] // 0x00000001898E28A0-0x00000001898E28C0
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE63A0-0x0000000181CE6490
		// [XID] // 0x00000001898EA370-0x00000001898EA390
		public void Init(int templateID) {} // 0x0000000181CE62F0-0x0000000181CE63A0
	}

	private class CmdEmitSubEmitterParticlesWithSpcifyPosition : MonoEffectCmdBase // TypeDefIndex: 19766
	{
		// Fields
		private Vector3 _position; // 0x10

		// Constructors
		public CmdEmitSubEmitterParticlesWithSpcifyPosition() {} // 0x0000000181CE58F0-0x0000000181CE5990

		// Methods
		// [XID] // 0x00000001898F1B10-0x00000001898F1B30
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181CE57E0-0x0000000181CE58F0
		// [XID] // 0x00000001898F92B0-0x00000001898F92D0
		public void Init(Vector3 position) {} // 0x0000000181CE5710-0x0000000181CE57E0
	}

	private class CmdChangeFollowDampTime : MonoEffectCmdBase // TypeDefIndex: 19767
	{
		// Fields
		private bool _effectNameEmpty; // 0x10
		private string _effectName; // 0x18
		private float _positionDampTime; // 0x20
		private float _rotationDampTime; // 0x24

		// Constructors
		public CmdChangeFollowDampTime() {} // 0x0000000181D08FE0-0x0000000181D09080

		// Methods
		// [XID] // 0x0000000189900BF0-0x0000000189900C10
		public override void InvokeCommand(MonoEffect monoEffect) {} // 0x0000000181D08ED0-0x0000000181D08FE0
		// [XID] // 0x0000000189908370-0x0000000189908390
		public void Init(bool effectNameEmpty, string effectName, float positionDampTime, float rotationDampTime) {} // 0x0000000181D08DD0-0x0000000181D08ED0
	}

	// Constructors
	public MonoEffectProxy() {} // Dummy constructor
	public MonoEffectProxy(string effectName, BaseEntity owner) {} // 0x0000000181CF9870-0x0000000181CF9960

	// Methods
	// [XID] // 0x0000000189B64D60-0x0000000189B64D80
	private void AddToQueueOrInvokeDirectly(MonoEffectCmdBase cmd) {} // 0x0000000181CF88C0-0x0000000181CF8A40
	// [XID] // 0x000000018978AA40-0x000000018978AA60
	private void FlushCmdQueue() {} // 0x0000000181CF9100-0x0000000181CF9250
	// [XID] // 0x00000001897920E0-0x0000000189792100
	public void AttachEffect(MonoEffect monoEffect) {} // 0x0000000181CF85C0-0x0000000181CF86B0
	// [XID] // 0x0000000189619C70-0x0000000189619C90
	public void AddCustomCmd(Action<MonoEffect> customCommand) {} // 0x0000000181CF8C40-0x0000000181CF8D30
	// [XID] // 0x00000001897A1520-0x00000001897A1540
	public void SetEffectActiveCmd(bool active, bool checkOwner) {} // 0x0000000181CF87B0-0x0000000181CF88C0
	// [XID] // 0x00000001897A8DA0-0x00000001897A8DC0
	public void SetEffectStopCmd() {} // 0x0000000181CF9250-0x0000000181CF9330
	// [XID] // 0x0000000189A53990-0x0000000189A539B0
	public void SetEffectDeallocateCmd() {} // 0x0000000181CF80F0-0x0000000181CF81D0
	// [XID] // 0x00000001897B8440-0x00000001897B8460
	public void SetVisibleCmd(bool enable) {} // 0x0000000181CF8B50-0x0000000181CF8C40
	// [XID] // 0x00000001897C0500-0x00000001897C0520
	public void SetPositionCmd(Vector3 position) {} // 0x0000000181CF8A40-0x0000000181CF8B50
	// [XID] // 0x00000001897C7D90-0x00000001897C7DB0
	public void SetForwardCmd(Vector3 forward) {} // 0x0000000181CF83A0-0x0000000181CF84B0
	// [XID] // 0x0000000189B96F30-0x0000000189B96F50
	public void SetPositionAndRotationCmd(Vector3 position, Quaternion rotation) {} // 0x0000000181CF8D30-0x0000000181CF8F10
	// [XID] // 0x00000001897D67E0-0x00000001897D6800
	public void SetMonoEffectPluginAnimatorPoseCmd(bool effectNameEmpty, string effectName, string parameter, AnimatorParamType type, int value) {} // 0x0000000181CF8F10-0x0000000181CF9060
	// [XID] // 0x00000001897DDFD0-0x00000001897DDFF0
	public void SetMonoEffecAnimatorParamFloat(string effectName, int parameter, float value) {} // 0x0000000181CF9540-0x0000000181CF9660
	// [XID] // 0x00000001897E5A20-0x00000001897E5A40
	public void StopShaderFadePluginCmd() {} // 0x0000000181CF81D0-0x0000000181CF82B0
	// [XID] // 0x00000001897ED510-0x00000001897ED530
	public void ApplyEffectArgsTemplateCmd(int templateID) {} // 0x0000000181CF82B0-0x0000000181CF83A0
	// [XID] // 0x00000001897F4C90-0x00000001897F4CB0
	public void EmitSubEmitterParticlesWithSpcifyPositionCmd(Vector3 position) {} // 0x0000000181CF84B0-0x0000000181CF85C0
	// [XID] // 0x00000001897FC760-0x00000001897FC780
	public void SetChangeFollowDampTimeCmd(bool effectNameEmpty, string effectName, float positionDampTime, float rotationDampTime) {} // 0x0000000181CF9330-0x0000000181CF9470
	// [XID] // 0x00000001898290A0-0x00000001898290C0
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000181CF9700-0x0000000181CF9870
}

