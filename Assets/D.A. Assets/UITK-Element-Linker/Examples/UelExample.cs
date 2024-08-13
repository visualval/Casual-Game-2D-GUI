using UnityEngine;

namespace DA_Assets.UEL
{
    public class UelExample : MonoBehaviour
    {
        [SerializeField] UitkButton addPhotoBtn;

        private void Start()
        {
            //Access to your UITK element.
            UnityEngine.UIElements.Button btn = addPhotoBtn.E;
            Debug.Log(btn.name);
        }

        //You don't need to use 'RegisterCallback<ClickEvent>'.
        public void AddPhoto_OnClick()
        {
            Debug.Log($"{addPhotoBtn.E.name} clicked!");
        }
    }
}
