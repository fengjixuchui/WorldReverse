/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public class tk<T, TContext> // TypeDefIndex: 4888
	{
		// Nested types
		public class Box : tkControl<T, TContext> // TypeDefIndex: 4889
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _control;
	
			// Constructors
			public Box() {} // Dummy constructor
			public Box(tkControl<T, TContext> control) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Button : tkControl<T, TContext> // TypeDefIndex: 4890
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, fiGUIContent> _label;
			private readonly bool _enabled;
			private readonly Action<T, TContext> _onClick;
	
			// Constructors
			public Button() {} // Dummy constructor
			public Button(string methodName) {}
			public Button(Value<T, TContext, fiGUIContent> label, Action<T, TContext> onClick) {}
			public Button(fiGUIContent label, Action<T, TContext> onClick) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class CenterVertical : tkControl<T, TContext> // TypeDefIndex: 4893
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _centered;
	
			// Constructors
			public CenterVertical() {} // Dummy constructor
			public CenterVertical(tkControl<T, TContext> centered) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Color : ColorIf<T, TContext> // TypeDefIndex: 4894
		{
			// Constructors
			public Color() {} // Dummy constructor
			public Color(Value<T, TContext, UnityEngine.Color> color) {}
		}
	
		public class ColorIf : ConditionalStyle<T, TContext> // TypeDefIndex: 4896
		{
			// Constructors
			public ColorIf() {} // Dummy constructor
			public ColorIf(Value<T, TContext, bool> shouldActivate, Value<T, TContext, Color> color) {}
			public ColorIf(Value<T, TContext, bool> shouldActivate, Value<T, TContext, Color> color) {}
			public ColorIf(Value<T, TContext, bool> shouldActivate, Value<T, TContext, Color> color) {}
		}
	
		public class Comment : tkControl<T, TContext> // TypeDefIndex: 4899
		{
			// Fields
			private readonly Value<T, TContext, string> _comment;
			private readonly CommentType _commentType;
	
			// Constructors
			public Comment() {} // Dummy constructor
			public Comment(Value<T, TContext, string> comment, CommentType commentType) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class ConditionalStyle : tkStyle<T, TContext> // TypeDefIndex: 4900
		{
			// Fields
			private readonly Func<T, TContext, bool> _shouldActivate;
			private readonly Func<T, TContext, object> _activate;
			private readonly Action<T, TContext, object> _deactivate;
			private readonly fiStackValue<bool> _activatedStack;
			private readonly fiStackValue<object> _activationStateStack;
	
			// Constructors
			public ConditionalStyle() {} // Dummy constructor
			public ConditionalStyle(Func<T, TContext, bool> shouldActivate, Func<T, TContext, object> activate, Action<T, TContext, object> deactivate) {}
	
			// Methods
			public override void Activate(T obj, TContext context) {}
			public override void Deactivate(T obj, TContext context) {}
		}
	
		public class Context : tkControl<T, TContext> // TypeDefIndex: 4901
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private tkControl<T, TContext> _control;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly fiStackValue<T> _data;
	
			// Properties
			public T Data { get => default; }
	
			// Constructors
			public Context() {}
	
			// Methods
			public tkControl<T, TContext> With(tkControl<T, TContext> control) => default;
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class DefaultInspector : tkControl<T, TContext> // TypeDefIndex: 4902
		{
			// Fields
			private readonly System.Type type_fitkControlPropertyEditor;
			private readonly System.Type type_IObjectPropertyEditor;
	
			// Constructors
			public DefaultInspector() {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class DisableHierarchyMode : tkControl<T, TContext> // TypeDefIndex: 4903
		{
			// Fields
			private tkControl<T, TContext> _childControl;
	
			// Constructors
			public DisableHierarchyMode() {} // Dummy constructor
			public DisableHierarchyMode(tkControl<T, TContext> childControl) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Empty : tkControl<T, TContext> // TypeDefIndex: 4904
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, float> _height;
	
			// Constructors
			public Empty() {}
			public Empty(Value<T, TContext, float> height) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class EnabledIf : ConditionalStyle<T, TContext> // TypeDefIndex: 4905
		{
			// Constructors
			public EnabledIf() {} // Dummy constructor
			public EnabledIf(Value<T, TContext, bool> isEnabled) {}
			public EnabledIf(Value<T, TContext, bool> isEnabled) {}
			public EnabledIf(Value<T, TContext, bool> isEnabled) {}
		}
	
		public class Foldout : tkControl<T, TContext> // TypeDefIndex: 4908
		{
			// Fields
			private readonly GUIStyle _foldoutStyle;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly fiGUIContent _label;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _control;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly bool _defaultToExpanded;
			private bool _doNotIndentChildControl;
			public bool? HierarchyMode;
	
			// Properties
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			public bool IndentChildControl { get => default; set {} }
	
			// Constructors
			public Foldout() {} // Dummy constructor
			public Foldout(fiGUIContent label, tkControl<T, TContext> control) {}
			public Foldout(fiGUIContent label, FontStyle fontStyle, tkControl<T, TContext> control) {}
			public Foldout(fiGUIContent label, FontStyle fontStyle, bool defaultToExpanded, tkControl<T, TContext> control) {}
	
			// Methods
			private tkFoldoutMetadata GetMetadata(fiGraphMetadata metadata) => default;
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class HorizontalGroup : tkControl<T, TContext>, IEnumerable // TypeDefIndex: 4909
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly List<SectionItem> _items;
			private static readonly tkControl<T, TContext> DefaultRule;
	
			// Properties
			protected override IEnumerable<tkIControl> NonMemberChildControls { get => default; }
	
			// Nested types
			private struct SectionItem // TypeDefIndex: 4910
			{
				// Fields
				private float _minWidth;
				private float _fillStrength;
				public bool MatchParentHeight;
				public tkControl<T, TContext> Rule;
				public bool Layout_IsFlexible;
				public float Layout_FlexibleWidth;
	
				// Properties
				[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
				public float MinWidth { get => default; set {} }
				[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
				public float FillStrength { get => default; set {} }
				public float Layout_Width { get => default; }
			}
	
			// Constructors
			public HorizontalGroup() {}
			static HorizontalGroup() {}
	
			// Methods
			public void Add(tkControl<T, TContext> rule) {}
			public void Add(bool matchParentHeight, tkControl<T, TContext> rule) {}
			public void Add(float width) {}
			public void Add(float width, tkControl<T, TContext> rule) {}
			private void InternalAdd(bool matchParentHeight, float width, float fillStrength, tkControl<T, TContext> rule) {}
			private void DoLayout(Rect rect, T obj, TContext context, fiGraphMetadata metadata) {}
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		public class Indent : tkControl<T, TContext> // TypeDefIndex: 4912
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, float> _indent;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _control;
	
			// Constructors
			public Indent() {} // Dummy constructor
			public Indent(tkControl<T, TContext> control) {}
			public Indent(Value<T, TContext, float> indent, tkControl<T, TContext> control) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class IntSlider : tkControl<T, TContext> // TypeDefIndex: 4913
		{
			// Fields
			private readonly Value<T, TContext, int> _min;
			private readonly Value<T, TContext, int> _max;
			private readonly Func<T, TContext, int> _getValue;
			private readonly Action<T, TContext, int> _setValue;
			private readonly Value<T, TContext, fiGUIContent> _label;
	
			// Constructors
			public IntSlider() {} // Dummy constructor
			public IntSlider(Value<T, TContext, int> min, Value<T, TContext, int> max, Func<T, TContext, int> getValue, Action<T, TContext, int> setValue) {}
			public IntSlider(Value<T, TContext, fiGUIContent> label, Value<T, TContext, int> min, Value<T, TContext, int> max, Func<T, TContext, int> getValue, Action<T, TContext, int> setValue) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Label : tkControl<T, TContext> // TypeDefIndex: 4914
		{
			// Fields
			public Value<T, TContext, fiGUIContent> GUIContent;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly FontStyle _fontStyle;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _control;
			public bool InlineControl;
	
			// Constructors
			public Label() {} // Dummy constructor
			public Label(fiGUIContent label) {}
			public Label(Value<T, TContext, fiGUIContent> label) {}
			public Label(Value<T, TContext, fiGUIContent> label) {}
			public Label(fiGUIContent label, FontStyle fontStyle) {}
			public Label(Value<T, TContext, fiGUIContent> label, FontStyle fontStyle) {}
			public Label(Value<T, TContext, fiGUIContent> label, FontStyle fontStyle) {}
			public Label(fiGUIContent label, tkControl<T, TContext> control) {}
			public Label(Value<T, TContext, fiGUIContent> label, tkControl<T, TContext> control) {}
			public Label(Value<T, TContext, fiGUIContent> label, tkControl<T, TContext> control) {}
			public Label(fiGUIContent label, FontStyle fontStyle, tkControl<T, TContext> control) {}
			public Label(Value<T, TContext, fiGUIContent> label, FontStyle fontStyle, tkControl<T, TContext> control) {}
			public Label(Value<T, TContext, fiGUIContent> label, FontStyle fontStyle, tkControl<T, TContext> control) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Margin : tkControl<T, TContext> // TypeDefIndex: 4915
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, float> _left;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, float> _top;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, float> _right;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly Value<T, TContext, float> _bottom;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _control;
	
			// Constructors
			public Margin() {} // Dummy constructor
			public Margin(Value<T, TContext, float> margin, tkControl<T, TContext> control) {}
			public Margin(Value<T, TContext, float> left, Value<T, TContext, float> top, tkControl<T, TContext> control) {}
			public Margin(Value<T, TContext, float> left, Value<T, TContext, float> top, Value<T, TContext, float> right, Value<T, TContext, float> bottom, tkControl<T, TContext> control) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Popup : tkControl<T, TContext> // TypeDefIndex: 4916
		{
			// Fields
			private readonly Value<T, TContext, fiGUIContent> _label;
			private readonly Value<T, TContext, GUIContent[]> _options;
			private readonly Value<T, TContext, int> _currentSelection;
			private readonly OnSelectionChanged _onSelectionChanged;
	
			// Nested types
			public delegate T OnSelectionChanged(T obj, TContext context, int selected); // TypeDefIndex: 4917; 0x00000000-0x00000000
	
			// Constructors
			public Popup() {} // Dummy constructor
			public Popup(Value<T, TContext, fiGUIContent> label, Value<T, TContext, GUIContent[]> options, Value<T, TContext, int> currentSelection, OnSelectionChanged onSelectionChanged) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class PropertyEditor : tkControl<T, TContext> // TypeDefIndex: 4918
		{
			// Fields
			private MemberInfo _attributes;
			private Func<T, TContext, object> _getValue;
			private Action<T, TContext, object> _setValue;
			private Value<T, TContext, fiGUIContent> _label;
			private System.Type _fieldType;
			private string _errorMessage;
	
			// Constructors
			public PropertyEditor() {} // Dummy constructor
			public PropertyEditor(string memberName) {}
			public PropertyEditor(fiGUIContent label, string memberName) {}
			public PropertyEditor(Value<T, TContext, fiGUIContent> label, string memberName) {}
			public PropertyEditor(fiGUIContent label, System.Type fieldType, MemberInfo attributes, Func<T, TContext, object> getValue, Action<T, TContext, object> setValue) {}
	
			// Methods
			private void InitializeFromMemberName(string memberName) {}
			public static PropertyEditor<T, TContext> Create<TEdited>(fiGUIContent label, MemberInfo attributes, Func<T, TContext, TEdited> getValue, Action<T, TContext, TEdited> setValue) => default;
			public static PropertyEditor<T, TContext> Create<TEdited>(fiGUIContent label, Func<T, TContext, TEdited> getValue) => default;
			public static PropertyEditor<T, TContext> Create<TEdited>(fiGUIContent label, Func<T, TContext, TEdited> getValue, Action<T, TContext, TEdited> setValue) => default;
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class StyleProxy : tkControl<T, TContext> // TypeDefIndex: 4924
		{
			// Fields
			public tkControl<T, TContext> Control;
	
			// Constructors
			public StyleProxy() {}
			public StyleProxy(tkControl<T, TContext> control) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class ReadOnly : ReadOnlyIf<T, TContext> // TypeDefIndex: 4925
		{
			// Constructors
			public ReadOnly() {}
		}
	
		public class ReadOnlyIf : ConditionalStyle<T, TContext> // TypeDefIndex: 4927
		{
			// Constructors
			public ReadOnlyIf() {} // Dummy constructor
			public ReadOnlyIf(Value<T, TContext, bool> isReadOnly) {}
			public ReadOnlyIf(Value<T, TContext, bool> isReadOnly) {}
			public ReadOnlyIf(Value<T, TContext, bool> isReadOnly) {}
		}
	
		public class ShowIf : tkControl<T, TContext> // TypeDefIndex: 4929
		{
			// Fields
			private readonly Value<T, TContext, bool> _shouldDisplay;
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly tkControl<T, TContext> _control;
	
			// Constructors
			public ShowIf() {} // Dummy constructor
			public ShowIf(Value<T, TContext, bool> shouldDisplay, tkControl<T, TContext> control) {}
			public ShowIf(Value<T, TContext, bool> shouldDisplay, tkControl<T, TContext> control) {}
			public ShowIf(Value<T, TContext, bool> shouldDisplay, tkControl<T, TContext> control) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
			public override bool ShouldShow(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class Slider : tkControl<T, TContext> // TypeDefIndex: 4930
		{
			// Fields
			private readonly Value<T, TContext, float> _min;
			private readonly Value<T, TContext, float> _max;
			private readonly Func<T, TContext, float> _getValue;
			private readonly Action<T, TContext, float> _setValue;
			private readonly Value<T, TContext, fiGUIContent> _label;
	
			// Constructors
			public Slider() {} // Dummy constructor
			public Slider(Value<T, TContext, float> min, Value<T, TContext, float> max, Func<T, TContext, float> getValue, Action<T, TContext, float> setValue) {}
			public Slider(Value<T, TContext, fiGUIContent> label, Value<T, TContext, float> min, Value<T, TContext, float> max, Func<T, TContext, float> getValue, Action<T, TContext, float> setValue) {}
	
			// Methods
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		}
	
		public class VerticalGroup : tkControl<T, TContext>, IEnumerable // TypeDefIndex: 4931
		{
			// Fields
			[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
			private readonly List<SectionItem> _items;
			private readonly float _marginBetweenItems;
	
			// Properties
			protected override IEnumerable<tkIControl> NonMemberChildControls { get => default; }
	
			// Nested types
			private struct SectionItem // TypeDefIndex: 4932
			{
				// Fields
				public tkControl<T, TContext> Rule;
			}
	
			// Constructors
			public VerticalGroup() {}
			public VerticalGroup(float marginBetweenItems) {}
	
			// Methods
			public void Add(tkControl<T, TContext> rule) {}
			private void InternalAdd(tkControl<T, TContext> rule) {}
			protected override T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
			protected override float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		public struct Value<TValue> // TypeDefIndex: 4934
		{
			// Fields
			private Generator _generator;
			private TValue _direct;
	
			// Nested types
			public delegate TValue Generator(T input, TContext context); // TypeDefIndex: 4935; 0x00000000-0x00000000
	
			public delegate TValue GeneratorNoContext(T input); // TypeDefIndex: 4936; 0x00000000-0x00000000
	
			// Constructors
			public Value(Generator generator) {
				_generator = default;
				_direct = default;
			}
			public Value(GeneratorNoContext generator) {
				_generator = default;
				_direct = default;
			}
	
			// Methods
			public TValue GetCurrentValue(T instance, TContext context) => default;
			public static implicit operator Value<T, TContext, TValue>(TValue direct) => default;
			public static implicit operator Value<T, TContext, TValue>(Generator generator) => default;
			public static implicit operator Value<T, TContext, TValue>(GeneratorNoContext generator) => default;
			public static implicit operator Value<T, TContext, TValue>(Func<T, int, TValue> generator) => default;
			public static implicit operator Value<T, TContext, TValue>(Func<T, TValue> generator) => default;
		}
	
		// Constructors
		public tk() {}
	
		// Methods
		public static Value<TValue> Val<TValue>(Value<TValue> generator) => default;
		public static Value<TValue> Val<TValue>(Value<TValue> generator) => default;
		public static Value<TValue> Val<TValue>(TValue value) => default;
	}
}
