
namespace DesingPatterns.behaviorPatterns.Memento
{
    public class Document  
    {
        private string content;

        public void SetContent(string content) // Establece el contenido del docuemnto 
        {
            this.content = content;
        }

        public string GetContent()  
        {
            return content; // retorna el contenido del documento
        }

        public DocumentMemento SaveToMemento() //guarda el docuemento en memento 
        {
            return new DocumentMemento(content);
        }

        public void RestoreFromMemento(DocumentMemento memento) // restaura el contenido desde memento
        {
            content = memento.GetContent();
        }
    }
    public class DocumentMemento
    {
        private readonly string content;

        public DocumentMemento(string content) // guarda el estado del docuemento
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content; // retorna el contenido del documento pero que se guardo en memento 
        }
    }
    public class DocumentHistory
    {
        private Stack<DocumentMemento> history = new Stack<DocumentMemento>();

        public void Save(Document document) // guarda el docuemento en el historial en forma de pila 
        {
            history.Push(document.SaveToMemento());
        }

        public void Undo(Document document) // restaura el estado acutal del docuemento al último estado guardado 
        {
            if (history.Count > 0)
            {
                document.RestoreFromMemento(history.Pop());
            }
        }
    }
}
