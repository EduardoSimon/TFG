using BT.Editor;
using UnityEditor;
using UnityEngine;

namespace BT.Scripts
{
    public class StringBlackBoardVariable : BlackBoardVariable
    {
        [SerializeField] public string StringVariable;
        
        public override Rect DrawVariableInspector(Rect rect, string label, ref int id)
        {

            base.DrawVariableInspector(rect,label,ref id);
            
            EditorGUI.BeginChangeCheck();
            GUI.SetNextControlName("Variable"  + id);
            StringVariable = EditorGUI.TextField( rect,label,StringVariable);
            
            
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