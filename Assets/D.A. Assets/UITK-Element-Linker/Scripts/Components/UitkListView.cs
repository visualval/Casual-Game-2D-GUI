#if UNITY_2022_1_OR_NEWER
using UnityEngine.UIElements;

namespace DA_Assets.UEL
{
    public class UitkListView : UitkLinker<ListView> { }

    public class ListViewG : UnityEngine.UIElements.ListView, IHaveGuid
    {
        public string guid { get; set; }

        public new class UxmlFactory : UxmlFactory<ListViewG, UxmlTraits> { }

        public new class UxmlTraits : BaseListView.UxmlTraits
        {
            UxmlStringAttributeDescription m_Guid = GuidGenerator.GetGuidField();

            public override void Init(UnityEngine.UIElements.VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);

                ListViewG obj = ve as ListViewG;
                GuidGenerator.GenerateGuid(m_Guid, obj, bag, cc);
            }
        }
    }
}
#endif