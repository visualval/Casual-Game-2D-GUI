using System.Collections.Generic;
using UnityEngine.UIElements;

namespace DA_Assets.UEL
{
    public class UitkPopupWindow : UitkLinker<PopupWindow> { }

    public class PopupWindowG : UnityEngine.UIElements.PopupWindow, IHaveGuid
    {
        public string guid { get; set; }

        public new class UxmlFactory : UxmlFactory<PopupWindowG, UxmlTraits> { }

        public new class UxmlTraits : TextElement.UxmlTraits
        {
            UxmlStringAttributeDescription m_Guid = GuidGenerator.GetGuidField();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
            {
                get
                {
                    yield return new UxmlChildElementDescription(typeof(VisualElement));
                }
            }

            public override void Init(UnityEngine.UIElements.VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);

                PopupWindowG obj = ve as PopupWindowG;
                GuidGenerator.GenerateGuid(m_Guid, obj, bag, cc);
            }
        }
    }
}
