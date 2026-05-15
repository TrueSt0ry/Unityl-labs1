
   using UnityEngine;
    using UnityEngine.UI; // для использования Button
    
    [RequireComponent(typeof(Button))] 
     // это своего рода гарантия что Button присутсвует на данном обьекте, 
     // необходим для присваивания _button через GetComponent<Button>()
    public class ButtonSpriteChanger : MonoBehaviour
    {
        private Button _button;
    
        private void Awake()
        {
            _button = GetComponent<Button>();
        }
    
        public void ChangeButtonSprite(Sprite sprite)
        {
            _button.image.sprite = sprite; 
            // обращение к кнопке, ее компоненту Image затем к его спрайту, 
            // и изменить на наш отправленный параметр
        }
    } 
