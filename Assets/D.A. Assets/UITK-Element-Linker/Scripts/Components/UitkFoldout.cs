using UnityEngine.UIElements;

namespace DA_Assets.UEL
{
    public class UitkFoldout : UitkLinker<Foldout> { }

    public class FoldoutG : UnityEngine.UIElements.Foldout, IHaveGuid
    {
        public string guid { get; set; }

        public new class UxmlFactory : UxmlFactory<FoldoutG, UxmlTraits> { }

        public new class UxmlTraits : BindableElement.UxmlTraits
        {
            UxmlStringAttributeDescription m_Guid = GuidGenerator.GetGuidField();

            private UxmlStringAttributeDescription m_Text = new UxmlStringAttributeDescription
            {
                name = "text"
            };

            private UxmlBoolAttributeDescription m_Value = new UxmlBoolAttributeDescription
            {
                name = "value",
                defaultValue = true
            };

            public override void Init(UnityEngine.UIElements.VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);

                if (ve is FoldoutG foldout)
                {
                    foldout.text = m_Text.GetValueFromBag(bag, cc);
                    foldout.SetValueWithoutNotify(m_Value.GetValueFromBag(bag, cc));

                    FoldoutG obj = ve as FoldoutG;
                    GuidGenerator.GenerateGuid(m_Guid, obj, bag, cc);
                }
            }
        }
    }
}
