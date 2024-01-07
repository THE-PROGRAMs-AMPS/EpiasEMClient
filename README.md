# EPİAŞ Şeffaflık Platformu 2.0 Elektrik Piyasası Verileri
# EXIST Transparency Platform 2.0 Electricity Market Data 


> [!IMPORTANT] 
> EPİAŞ tarafından Şeffaflık Platformu 2.0 ile 04 Aralık 2023 tarihinde güncellenen web servisleri kullanıma açılmıştır. Eski ve yeni web servisleri 1 Mart 2024 tarihine kadar hizmet vermeye devam edecek olup sonraki süreçte yeni web servisleri ile hizmet verilecektir.  [EPİAŞ Duyuru](https://www.epias.com.tr/tum-duyurular/piyasa-duyurulari/elektrik/web-servis/seffaflik-platformu-web-servisleri-erisim-tarihi-hakkinda-guncelleme/)



## Simple Code Usage Example

```C#
using EpiasElectricityMarketClient;
….
  try
  {
      //initialize web service client
      EpiasAPIClient client = new EpiasAPIClient(new HttpClient());
      //set all required values
      PtfRequestDto body = new PtfRequestDto();
      body.StartDate = DateTime.Now.AddDays(-7);
      body.EndDate = DateTime.Now;
      //call the service
      PtfResponseDto response = await client.McpDataAsync(body);
      // show the data
      dataGridView1.DataSource = response.Items;
  }
  catch (ApiException ex)
  {
      MessageBox.Show(ex.Message.ToString());
  }

```
## Sample MCP Data 
![MCP_Data](https://github.com/CedricScottish/EpiasEMClient/assets/61628447/49e29b7f-8c9a-407c-b59e-56157c953e1d)

## Dependence
- Newtonsoft.Json [Official Site](https://www.newtonsoft.com/json)
## Reference 
-  https://seffaflik.epias.com.tr/electricity-service/technical/tr/index.html 
