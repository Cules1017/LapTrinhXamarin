using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class Animal
    {
        public string Aname { get; set; }
        public string Ainfo { get; set; }
        public string Aimg { get; set; }
        public string AHo { get; set; }
        public Animal(string ho, string aname, string ainfo, string aimg)
        {
           
            Aname = aname;
            Ainfo = ainfo;
            Aimg = aimg;
            AHo = ho;
        }
    }
    public partial class AnimalView : ContentPage
    {
        public List<Animal> animals = new List<Animal>();

        public AnimalView(AnimalFamily a)
        {
            
            if (a.AFid == 1)
            {
                animals.Add(new Animal("Chó","Chó Chihuahua", "Chó Chihuahua là một trong những giống chó nuôi nhỏ nhất trên thế giới. Cái tên Chihuahua được đặt theo tên của bang Chihuahua ở México. Giống chó này rất thông minh.", "cho_1.jpg"));
                animals.Add(new Animal("Chó", "Chó Dachshund", "Chó Dachshund còn gọi là chó xúc xích, chó lạp xưởng. Chúng là giống chó thân dài, ngực nở, bụng hóp, hoạt bát, rắn chắc với tứ chi rất ngắn. Chúng tạo cho giống chó này một dáng vẻ độc đáo và đầy chất thông thái. Đầu thuôn dài, mắt hơi lồi, mõm dài với bộ hàm khoẻ mạnh cùng những chiếc răng vô cùng sắc bén.", "cho_2.jpg"));
                animals.Add(new Animal("Chó", "Chó Phú Quốc", "Chó Phú Quốc là một loại chó riêng của đảo Phú Quốc, Việt Nam. Nó có đặc điểm phân biệt với các loại chó khác là các xoáy lông ở trên sống lưng. Nó là một trong ba dòng chó có xoáy lông trên lưng trên thế giới. Hai loại chó lông xoáy ở lưng còn lại là chó lông xoáy Rhodesia và chó lông xoáy Thái.", "cho_3.jpg"));
                animals.Add(new Animal("Chó", "Chó Cỏ Việt Nam", "Chó cỏ hay chó ta, chó nội chó mực, chó vện, chó dé hay còn gọi chung là chó Việt Nam là các giống chó thuần chủng có nguồn gốc tại Việt Nam. Hiện ở Việt Nam có bốn giống chó nội có giá trị và được gọi là tứ đại quốc khuyển gồm: chó Bắc Hà, chó Lài, H’mông cộc đuôi và chó Phú Quốc.", "cho_4.jpg"));
                animals.Add(new Animal("Chó", "Chó Nhật", "Chó Nhật là giống chó của hoàng gia Nhật. Giống chó này thường được nuôi làm cảnh hoặc để bầu bạn.", "cho_5.jpg"));
                animals.Add(new Animal("Chó", "Chó Alaska", "Chó Alaska (Alaskan malamute) là giống chó săn có thân hình to khỏe với bộ lông xù màu sắc đẹp như hồng phấn, nâu đỏ hay tuyết trắng tính cách thận thiện, ...", "cho_6.jpg"));
                Title = "Các động vật thuộc họ chó";
            }
            else if (a.AFid == 2)
            {
                animals.Add(new Animal("Mèo","Mèo Ba Tư", "Giống mèo đáng yêu này có nguồn gốc từ nước Iran ( Ba tư cổ) nên được mệnh danh là mèo Ba tư, với vẻ ngoài sang chảnh cùng bộ lông dài thướt tha, tính tình thùy mị và hiền lành nên được giới quý tộc Phương Tây ngày xưa yêu thích và cưng chiều.\r\n\r\nThân hình nằm ở mức trung bình, đầu và mắt to, khuôn mặt tẹt, mũi và tai nhỏ, tai nhỏ hình tam giác. Giống mèo này được chia thành 4 dòng nhỏ và nhiều màu sắc khác nhau gồm Mèo Ba Tư lông dài, mèo Ba Tư lông ngắn, mèo Ba Tư Himalaya, mèo Chinchilla. Mỗi dòng như vậy sẽ có một mức giá khác nhau", "meo_1.jpg"));
                animals.Add(new Animal("Mèo", "Mèo Ai Cập", "Kêu là mèo Ai cập nhưng hộ khẩu em này là Toronto, Canada cái tên mèo Sphynx là tên láy âm Sphinx nghĩa là nhân sư, với bề ngoài giống bức tượng như vậy nên loài mèo này được đặt tên theo đó.\r\n\r\nĐây là loài mèo đắt nhất thế giới với ngoại hình khá lạ như không hề có lông, nhiều nếp nhăn, cứng cáp, có cơ bắp, đầu hơi nhọn, đôi mắt hình quả chanh, tai to, xương gò má nhô cao, đuôi dài. Màu da cũng rất là đa dạng gồm trắng, đen, đỏ.", "meo_2.jpg"));
                animals.Add(new Animal("Mèo", "Mèo Mướp", "Giống mèo nuôi nhiều nhất tại Việt Nam bởi tính thông minh, dễ nuôi, leo trèo giỏi và tính tự lập cao, không cần cưng nựng nhiều. Ngoại hình không chói lóa, sang chảnh như các giống mèo ngoại quốc, mèo vàng cực kì dân dã với màu lông vàng toàn thân cùng các ngấn trắng, thân hình cân đối, dáng cao, mắt vàng đen, tai vểnh cao, mõm dài.\r\n\r\nLoài mèo này thích nô đùa, ưa vận động và thức ăn cho mèo vàng cũng dễ tìm hơn. Mèo vàng không nghịch như mèo mướp, ngoài ra dân gian truyền tai nhau là nuôi mèo này mang đến cho gia chủ tiền tài, may mắn và sự sung túc.", "meo_03.jpg"));
                animals.Add(new Animal("Mèo","Mèo Vàng", "Một giống mèo của nước Việt Nam và gần gũi mỗi gia đình Việt, mèo Mướp với tính cách tinh ranh, nghịch ngợm nhưng thông minh làm cho nhiều gia đình chọn nuôi nó trong nhà.\r\n\r\nNgoại hinh nhỏ nhắn, khuôn mặt nhỏ, tai vểnh cao và đuôi dài, bộ lông ngắn, sọc vằn đen cùng chữ M trên trán làm nên thương hiệu giống mèo mướp này. Loài mèo này thích tắm nắng, liếm lông, ăn vụng và chải chuốt, ngủ nhiều nhưng có tài leo trèo, nhảy nhót, năng động nên được nhiều bạn trẻ đón chào.", "meo_04.jpg"));
                animals.Add(new Animal("Mèo", "Mèo Xiêm", "Đến từ xứ sở chùa Vàng, mèo Xiêm được xem là giống mèo lông ngắn phương với tính cách gần gũi, dễ nuôi và đôi khi khá thô bạo. Giống mèo này có hai dòng chính gồm :\r\n\r\nDòng truyền thống có thân hình cân đối, mặt to tròn và giống mèo vàng hay mèo mướp.\r\n\r\nDòng hiện đại có thân hình mảnh khảnh, thon gọn, lông ngắn và dày có màu socola hay xám, mặt nhiều góc cạnh.", "meo_05.jpg"));
                Title = "Các động vật thuộc họ mèo";
            }
            else if(a.AFid == 3)
            {
                animals.Add(new Animal("Rùa", "Rùa  Common snapping", "Rùa Common snapping là một loài rùa cảnh đến từ Bắc Mỹ. Trên mai rùa này có một lớp gai chạy dọc mai rùa rất chắc khỏe. Hiện tại loài rùa này được nhiều người lựa chọn nuôi làm cảnh. Giá bán của chúng rơi vào tầm 200k/1 con.", "Rua_1.jpg"));
             
                animals.Add(new Animal("Rùa", "Rùa bản đồ – Map turtle", "Rùa bản đồ –  Map turtle là một loài rùa cảnh hiện được nhiều người yêu thích, chúng có rất nhiều màu sắc khác nhau như màu nâu, nâu nhạt, xanh lá cây, da cam, vàng, đen, xám.\r\n\r\nĐặc điểm nhận dạng rùa bản đồ đó là trên mai có một hàng gai nhọn, cứng chạy dọc chính giữa. ", "Rua_2.jpg"));
                animals.Add(new Animal("Rùa", "Rùa bụng vàng – Yellow bellied", "Đây cũng là một loại rùa nước cảnh đang được nhiều nuôi nhất trên thế giới. Chúng có nguồn gốc từ Nam Hoa kỳ. Để nhận biết được rùa bụng vàng các bạn có thể để ý qua phần bụng có màu vàng và có một vài đốm đen, trên đầu và mai chúng cũng có vệt màu vàng. ", "Rua_3.jpg"));
                animals.Add(new Animal("Rùa", "Rùa kim cương Diamond back terrapin", "Rùa kim cương có nhiều màu khác nhau như xám, nâu, xanh lục, đen. Trên da có một lớp đốm tối màu. ", "Rua_4.jpg"));
                Title = "Các động vật thuộc họ rùa";
            }
            else if (a.AFid == 4)
            {
                animals.Add(new Animal("Lớp Chim", "Chim oanh châu Âu - Anh", "Loại chim này có hình thức ăn uống khá dễ, thức ăn chính của chúng là những con châu chấu, trứng kiến, cào cào, đặc biệt là trái cây. Nếu bạn không có thời gian để mua các loại thức ăn trên thì bạn có thể mua các loại cám cho chim ăn dần cũng được.\r\n\r\nViệc nuôi chim này bạn sẽ không cần phải suy nghĩ hôm nay thực đơn cho chúng ăn sẽ là món gì. Trung bình, giá của một giống sáo tốt dao động từ 200 ngàn đến 4 triệu đồng mỗi con.", "chim_1.jpg"));
                animals.Add(new Animal("Lớp Chim", "Chim Chích Chòe", "Tuy Chích Chòe không sở hữu một ngoại hình quá ư bắt mắt, nhưng chúng lại có một dáng vẻ nhỏ nhắn siêu dễ thương, và cách nuôi chim này cũng khá là dễ dàng. Trước khi muốn nuôi loài chim này, có một vấn đề mà bạn cần lưu ý là chúng sở hữu một chất giọng khá đặc biệt.\r\n\r\nNgoài ra, còn hay hót vào ban trưa và buổi tối, thể nên nếu bạn muốn mình có một chút không gian yên tĩnh bạn nên nhốt chúng cách xa không gian của bạn. Chuyện ăn uống của em này cũng giống như nuôi chim sáo vậy.", "chim_2.jpg"));
                animals.Add(new Animal("Lớp Chim", "Chim họa mi", "Loài chim cảnh Việt Nam này khá nhỏ bé, chỉ ngang hoặc bé hơn chim Sơn Ca nhưng bù lại chúng có giọng hót rất hay, trong trẻo. Tiếng hót của chim Họa Mi có thể làm cho người nghe cảm giác dễ chịu, xóa tan căng thẳng.\r\n\r\nBởi vậy mà người ta thường ví các ca sĩ có giọng hát cao là những chú chim họa mi. Tuy nhiên không phải con nào cũng hót hay, một số con có giọng hơi khàn, thấp sẽ không được đánh giá cao.", "chim_3.jpg"));
                animals.Add(new Animal("Lớp Chim", "Chim Vẹt", "Chim Vẹt có thể cho là loài chim gây được sự chú ý nhất tới mọi người, với màu sắc bắt mắt, đáng yêu và đặc biệt là khả năng bắt chước tiếng người. Người chơi Vẹt thường nuôi để giải trí và làm bầu bạn với mình.\r\n\r\nTuy nhiên bạn sẽ khá vất vả do chúng vẫn còn tính hoang dã, bừa bộn, không chịu nghe theo lời dạy của chủ.Thức ăn của Vẹt khá đơn giản, thường là các loại hạt, hoa quả, thực vật,… Song vẫn có một số ít các loài Vẹt có thể ăn thịt sống và xác thối.", "chim_4.jpg"));
                animals.Add(new Animal("Lớp Chim", "Chim Khuyên", "Chim Khuyên là một trong các loài chim cảnh nhỏ được nuôi nhiều nhất ở Việt Nam nhờ màu lông đẹp và tiếng hót hay. Thân hình của chim Khuyên nhỏ nhắn, đầu chim khá to so với phần thân, trán rộng và cao, mắt hơi xếch nhẹ, mắt có vòng khuyên trắng, có bộ lông màu vàng lục.\r\n\r\nLoài chim này khá khó nuôi và chăm sóc nhưng vẫn thu hút những người chơi chim bởi giọng líu đầy trong trẻo của loài chim này.Thức ăn của loài chim này chủ yếu là côn trùng, mật hoa, quả nhỏ,…", "chim_5.jpg"));
                Title = "Các động vật thuộc họ chim";
            }
            InitializeComponent();
            listanimal.ItemsSource = animals;
        }
       /* public static List<string> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            return animals.Where(f => f.ToLowerInvariant().Contains(normalizedQuery)).ToList();
        }*/
        private void listanimal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Animal a = (Animal)listanimal.SelectedItem;
            Navigation.PushAsync(new AnimalDetailView(a));
        }

        private void searchbarcv_SearchButtonPressed(object sender, EventArgs e)
        {
            string queryString = searchbarcv.Text;
            var normalizedQuery = queryString?.ToLower() ?? "";
            List<Animal> a= animals.Where(f => f.Aname.ToLowerInvariant().Contains(normalizedQuery)|| f.Ainfo.ToLowerInvariant().Contains(normalizedQuery)).ToList();
          
           
            listanimal.ItemsSource = a;
        }
    }
}