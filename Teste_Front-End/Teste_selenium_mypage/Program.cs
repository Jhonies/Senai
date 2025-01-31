using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            // Navegar para o Gamemania
            string url = "http://localhost:4200/";
            driver.Navigate().GoToUrl(url);
            Console.WriteLine($"Navegando para {url}");

            // Acha a barra de pesquisa
            IWebElement searchField = driver.FindElement(By.XPath("//*[@id=\"navbarContent\"]/div[1]/input")); // O campo de pesquisa possui o atributo 'name=q'

            // Inserir o termo de pesquisa
            string searchTerm = "Produto";
            searchField.Click();
            searchField = driver.FindElement(By.XPath("//*[@id=\"navbarContent\"]/div[1]/input"));
            searchField.SendKeys(searchTerm);
            Console.WriteLine($"Inserindo o termo de pesquisa: {searchTerm}");

            // Simular o envio da pesquisa (pressionar Enter no campo de texto)
            searchField.SendKeys(Keys.Enter);
            Console.WriteLine("Realizando a pesquisa.");

            // Esperar que os resultados carreguem
            System.Threading.Thread.Sleep(2000); // Pausa simples para carregamento

            // Validar se os resultados foram exibidos
            IWebElement resultsSection = driver.FindElement(By.ClassName("card-title")); // Verifica se houve retorno de resultados com a palavra pesquisada.
            if (resultsSection.Displayed)
            {
                Console.WriteLine("Resultados da pesquisa exibidos com sucesso!");

                var produtos = driver.FindElements(By.ClassName("card-title")).Take(3); // Pega os 3 primeiros produtos
                foreach (var produto in produtos)
                {
                    var botaoaddCarrinho = produto.FindElement(By.XPath("//button[contains(@class, 'btn') and contains(@class, 'btn-primary') and contains(@class, 'w-100')]"));
                    botaoaddCarrinho.Click(); // Clica no botão de adicionar ao carrinho
                }

                System.Threading.Thread.Sleep(3000);
                //Clica no botão de carrinho
                IWebElement botaoCarrinho = driver.FindElement(By.XPath("//*[@id=\"navbarContent\"]/div[2]/button[2]"));
                botaoCarrinho.Click();

                System.Threading.Thread.Sleep(2000);



                // Capturar o texto dos itens adicionados ao carrinho
                IWebElement carrinhosResult = driver.FindElement(By.XPath("/html/body/app-root/main/app-cart/section/div/table/tbody/tr/td[1]")); // O seletor irá copiar o texto que aparecer no local determinado pelo XPath
                Console.WriteLine("Produtos nos carrinhos:");
                Console.WriteLine(carrinhosResult.Text); // Exibe os produtos no console
                
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