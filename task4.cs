class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposed = false;
      
       ~DisposePatternImplementer()
        {
           
             Console.WriteLine("Disposing by GC");
             Close();
            Dispose(false);
            
           
        }
        public void Dispose()
        {
          
            Dispose(true);
            GC.SuppressFinalize(this);
           
        }
        protected virtual void Dispose(bool disposing)
        {
             
            if (!disposed)
            {
                
              
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                   Close();
                }
                  
            }
            
            disposed = true;
        }
       

       
    } 
