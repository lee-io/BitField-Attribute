using System;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(BitFieldAttribute))]
public sealed class BitFieldAttributeDrawer : PropertyDrawer
{
	// Draw the enum as an Editor MaskField
	public override sealed void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		if (property.propertyType == SerializedPropertyType.Enum)
		{
			// Ensure underlying integer support
			var type = Enum.GetUnderlyingType(fieldInfo.FieldType);
			
			if (type == typeof(SByte) ||
				type == typeof(Int16) ||
				type == typeof(Int32))
			{
				EditorGUI.BeginProperty(position, label, property);
				property.intValue = EditorGUI.MaskField(position, label, property.intValue, property.enumDisplayNames);
				EditorGUI.EndProperty();
				
				return;
			}
		}

		EditorGUI.LabelField(position, label.text, "Unsupported field type.");
	}
}
