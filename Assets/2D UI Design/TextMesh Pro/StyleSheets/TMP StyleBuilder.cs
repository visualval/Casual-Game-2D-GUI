using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace VisualDesign.Tools.Typography

{
    public class TMPStyleBuilder : MonoBehaviour
    {
        public TMP_Text Textbox;
        public string OpenTags;
        public string CloseTags;

        [ContextMenu(itemName:"Read Values from TMP")]

        public void ReadValuesFromTMP ()
        {
            StringBuilder openSB = new StringBuilder();
            StringBuilder closeSB = new StringBuilder();

            if ((Textbox.fontStyle & FontStyles.Bold) != 0)
            {
                openSB.Append("<b>");
                closeSB.Append("</b>");
            }

            if ((Textbox.fontStyle & FontStyles.Underline) != 0)
            {
                openSB.Append("<underline>");
                closeSB.Append("</underline>");
            }

            if ((Textbox.fontStyle & FontStyles.Strikethrough) != 0)
            {
                openSB.Append("<strikethrough>");
                closeSB.Append("</strikethrough>");
            }

            if ((Textbox.fontStyle & FontStyles.Italic) != 0)
            {
                openSB.Append("<i>");
                closeSB.Append("</i>");
            }

            if ((Textbox.fontStyle & FontStyles.UpperCase) != 0)
            {
                openSB.Append("<uppercase>");
                closeSB.Append("</uppercase>");
            }

            if ((Textbox.fontStyle & FontStyles.LowerCase) != 0)
            {
                openSB.Append("<lowercase>");
                closeSB.Append("</lowercase>");
            }

            if ((Textbox.fontStyle & FontStyles.SmallCaps) != 0)
            {
                openSB.Append("<smallcaps>");
                closeSB.Append("</smallcaps>");
            }

            if ((Textbox.fontStyle & FontStyles.Subscript) != 0)
            {
                openSB.Append("<sup>");
                closeSB.Append("</sup>");
            }

            if ((Textbox.fontStyle & FontStyles.Subscript) != 0)
            {
                openSB.Append("<sub>");
                closeSB.Append("</sub>");
            }

            OpenTags = openSB.ToString();
            CloseTags = closeSB.ToString();
        }


    }

}


