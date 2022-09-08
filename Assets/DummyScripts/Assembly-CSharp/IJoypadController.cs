/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IJoypadController // TypeDefIndex: 30634
{
	// Methods
	int GetContextStateID();
	uint[] GetPriorityLevel();
	bool IsInvalid();
	bool IsActive();
	void ResetByInputActionEvents(InputActionEvent[] actions);
	bool HandleInputActionEvent(InputActionEvent actionEvent);
	void SetBaseContext(BaseContext context);
	BaseContext GetBaseContext();
	bool HandleJoypadControllerAction(JoypadControllerActionType action, object param);
}

