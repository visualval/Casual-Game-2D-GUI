#if UNITY_2021_3_OR_NEWER
using UnityEngine.UIElements;

namespace DA_Assets.UEL
{
    public class UitkGroupBox : UitkLinker<GroupBox> { }

    public class GroupBoxG : UnityEngine.UIElements.GroupBox, IHaveGuid
    {
        public string guid { get; set; }

        public new class UxmlFactory : UxmlFactory<GroupBoxG, UxmlTraits> { }

        public new class UxmlTraits : BindableElement.UxmlTraits
        {
            UxmlStringAttributeDescription m_Guid = GuidGenerator.GetGuidField();

            private UxmlStringAttributeDescription m_Text = new UxmlStringAttributeDescription
            {
                name = "text"
            };

            public override void Init(UnityEngine.UIElements.VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);
                ((GroupBoxG)ve).text = m_Text.GetValueFromBag(bag, cc);

                GroupBoxG obj = ve as GroupBoxG;
                GuidGenerator.GenerateGuid(m_Guid, obj, bag, cc);
            }
        }
    }
}
#endif