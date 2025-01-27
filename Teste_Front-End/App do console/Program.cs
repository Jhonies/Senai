using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

class Program
{
    static void Main(string[] args)
    {
        // Inicializar o driver do navegador
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Configurar o navegador para que ele inicie maximizado
            driver.Manage().Window.Maximize();

            // Navegar para o Senai
            string url = "https://www.sp.senai.br/";
            driver.Navigate().GoToUrl(url);
            Console.WriteLine($"Navegando para {url}");

            // Localizar o menu Cursos no site do Senai
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"dropdown-cursos\"]")); // O campo de pesquisa possui o atributo 'name=q' 

            // Cria a ação de mover o mouse até o elemento
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform(); // Mover o mouse para o elemento
            // Pausa o mouse em cima do elemento por 2 segundos (se necessário)
            System.Threading.Thread.Sleep(2000); // 2000 milissegundos = 2 segundos

            //Clica para Visualizar todos os cursos
            IWebElement searchField = driver.FindElement(By.XPath("//*[@id=\"v-pills-tab\"]/a[1]"));

            // Inserir o termo de pesquisa
            string searchTerm = "Tecnologia";
            searchField.Click();
            searchField = driver.FindElement(By.Id("titulopesquisa"));
            searchField.SendKeys(searchTerm);
            Console.WriteLine($"Inserindo o termo de pesquisa: {searchTerm}");

            // Simular o envio da pesquisa (pressionar Enter no campo de texto)
            searchField.SendKeys(Keys.Enter);
            Console.WriteLine("Realizando a pesquisa.");

            // Esperar que os resultados carreguem
            System.Threading.Thread.Sleep(2000); // Pausa simples para carregamento

            // Validar se os resultados foram exibidos
            IWebElement resultsSection = driver.FindElement(By.XPath("//*[contains(text(), 'tecnologia')]")); // Verifica se houve retorno de resultados com a palavra pesquisada.
            if (resultsSection.Displayed)
            {
                Console.WriteLine("Resultados da pesquisa exibidos com sucesso!");

                // Capturar o texto do local onde foi determinado a busca
                IWebElement firstResult = driver.FindElement(By.XPath("//*[@id=\"oqEstabuscando\"]/div[1]/div[1]/div/h5")); // O seletor irá copiar o texto que aparecer no local determinado pelo XPath
                Console.WriteLine("Título do primeiro resultado:");
                Console.WriteLine(firstResult.Text); // Exibe o título no console
            }
            else
            {
                Console.WriteLine("Falha ao exibir os resultados da pesquisa.");
                Console.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro durante a execução do teste: {ex.Message}");
            Console.ReadLine();
        }
        finally
        {
            // Finalizar o teste e fechar o navegador
            Console.WriteLine("Teste finalizado e navegador fechado.");
            driver.Quit();
        }
    }
}
