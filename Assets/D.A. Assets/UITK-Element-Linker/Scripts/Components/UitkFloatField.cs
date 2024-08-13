#if UNITY_2022_1_OR_NEWER
using UnityEngine.UIElements;

namespace DA_Assets.UEL
{
    public class UitkFloatField : UitkLinker<FloatField> { }

    public class FloatFieldG : UnityEngine.UIElements.FloatField, IHaveGuid
    {
        public string guid { get; set; }

        public new class UxmlFactory : UxmlFactory<FloatFieldG, UxmlTraits>   {    }

        public new class UxmlTraits : TextValueFieldTraits<float, UxmlFloatAttributeDescription>
        {
            UxmlStringAttributeDescription m_Guid = GuidGenerator.GetGuidField();

            public override void Init(UnityEngine.UIElements.VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);

                FloatFieldG obj = ve as FloatFieldG;
                GuidGenerator.GenerateGuid(m_Guid, obj, bag, cc);
            }
        }
    }
}
#endif