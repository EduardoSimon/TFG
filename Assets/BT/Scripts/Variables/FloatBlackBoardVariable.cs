using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace BT.Scripts
{
    public class FloatBlackBoardVariable : BlackBoardVariable
    {
        public float Variable = 5f;


        public override Rect DrawVariableInspector(Rect rect, string label,ref int id)
        {
            base.DrawVariableInspector(rect,label, ref id);
            GUI.SetNextControlName("Variable" + id);
            Variable = EditorGUI.FloatField(rect,label,Variable);
            
            if(Event.current.type == EventType.MouseDown && !rect.Contains(Event.current.mousePosition))
            {
                GUI.FocusControl(null);
                
            }
            else if(Event.current.type == EventType.MouseDown && rect.Contains(Event.current.mousePosition))
            {
                GUI.FocusControl("Variable" + id);
            }

            return rect;
        }
    }
}