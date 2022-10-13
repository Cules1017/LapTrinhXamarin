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
        public Animal( string aname, string ainfo, string aimg)
        {
           
            Aname = aname;
            Ainfo = ainfo;
            Aimg = aimg;
        }
    }
    public partial class AnimalView : ContentPage
    {
        public List<Animal> animals = new List<Animal>();

        public AnimalView(AnimalFamily a)
        {
            if (a.AFid == 1)
            {
                animals.Add(new Animal("Chó Chihuahua", "Chó Chihuahua là một trong những giống chó nuôi nhỏ nhất trên thế giới. Cái tên Chihuahua được đặt theo tên của bang Chihuahua ở México. Giống chó này rất thông minh.", "cho_1.jpg"));
                animals.Add(new Animal("Chó Dachshund", "Chó Dachshund còn gọi là chó xúc xích, chó lạp xưởng. Chúng là giống chó thân dài, ngực nở, bụng hóp, hoạt bát, rắn chắc với tứ chi rất ngắn. Chúng tạo cho giống chó này một dáng vẻ độc đáo và đầy chất thông thái. Đầu thuôn dài, mắt hơi lồi, mõm dài với bộ hàm khoẻ mạnh cùng những chiếc răng vô cùng sắc bén.", "cho_2.jpg"));
                animals.Add(new Animal("Chó Phú Quốc", "Chó Phú Quốc là một loại chó riêng của đảo Phú Quốc, Việt Nam. Nó có đặc điểm phân biệt với các loại chó khác là các xoáy lông ở trên sống lưng. Nó là một trong ba dòng chó có xoáy lông trên lưng trên thế giới. Hai loại chó lông xoáy ở lưng còn lại là chó lông xoáy Rhodesia và chó lông xoáy Thái.", "cho_3.jpg"));
                animals.Add(new Animal("Chó Cỏ Việt Nam", "Chó cỏ hay chó ta, chó nội chó mực, chó vện, chó dé hay còn gọi chung là chó Việt Nam là các giống chó thuần chủng có nguồn gốc tại Việt Nam. Hiện ở Việt Nam có bốn giống chó nội có giá trị và được gọi là tứ đại quốc khuyển gồm: chó Bắc Hà, chó Lài, H’mông cộc đuôi và chó Phú Quốc.", "cho_4.jpg"));
                animals.Add(new Animal("Chó Nhật", "Chó Nhật là giống chó của hoàng gia Nhật. Giống chó này thường được nuôi làm cảnh hoặc để bầu bạn.", "cho_5.jpg"));
                animals.Add(new Animal("Chó Alaska", "Chó Alaska (Alaskan malamute) là giống chó săn có thân hình to khỏe với bộ lông xù màu sắc đẹp như hồng phấn, nâu đỏ hay tuyết trắng tính cách thận thiện, ...", "cho_6.jpg"));
            }
            else if (a.AFid == 2)
            {
                animals.Add(new Animal("Mèo Ba Tư", "Giống mèo đáng yêu này có nguồn gốc từ nước Iran ( Ba tư cổ) nên được mệnh danh là mèo Ba tư, với vẻ ngoài sang chảnh cùng bộ lông dài thướt tha, tính tình thùy mị và hiền lành nên được giới quý tộc Phương Tây ngày xưa yêu thích và cưng chiều.\r\n\r\nThân hình nằm ở mức trung bình, đầu và mắt to, khuôn mặt tẹt, mũi và tai nhỏ, tai nhỏ hình tam giác. Giống mèo này được chia thành 4 dòng nhỏ và nhiều màu sắc khác nhau gồm Mèo Ba Tư lông dài, mèo Ba Tư lông ngắn, mèo Ba Tư Himalaya, mèo Chinchilla. Mỗi dòng như vậy sẽ có một mức giá khác nhau", "meo_1.jpg"));
                animals.Add(new Animal("Mèo Ai Cập", "Kêu là mèo Ai cập nhưng hộ khẩu em này là Toronto, Canada cái tên mèo Sphynx là tên láy âm Sphinx nghĩa là nhân sư, với bề ngoài giống bức tượng như vậy nên loài mèo này được đặt tên theo đó.\r\n\r\nĐây là loài mèo đắt nhất thế giới với ngoại hình khá lạ như không hề có lông, nhiều nếp nhăn, cứng cáp, có cơ bắp, đầu hơi nhọn, đôi mắt hình quả chanh, tai to, xương gò má nhô cao, đuôi dài. Màu da cũng rất là đa dạng gồm trắng, đen, đỏ.", "meo_2.jpg"));
                animals.Add(new Animal("Mèo Mướp", "Giống mèo nuôi nhiều nhất tại Việt Nam bởi tính thông minh, dễ nuôi, leo trèo giỏi và tính tự lập cao, không cần cưng nựng nhiều. Ngoại hình không chói lóa, sang chảnh như các giống mèo ngoại quốc, mèo vàng cực kì dân dã với màu lông vàng toàn thân cùng các ngấn trắng, thân hình cân đối, dáng cao, mắt vàng đen, tai vểnh cao, mõm dài.\r\n\r\nLoài mèo này thích nô đùa, ưa vận động và thức ăn cho mèo vàng cũng dễ tìm hơn. Mèo vàng không nghịch như mèo mướp, ngoài ra dân gian truyền tai nhau là nuôi mèo này mang đến cho gia chủ tiền tài, may mắn và sự sung túc.", "meo_03.jpg"));
                animals.Add(new Animal("Mèo Vàng", "Một giống mèo của nước Việt Nam và gần gũi mỗi gia đình Việt, mèo Mướp với tính cách tinh ranh, nghịch ngợm nhưng thông minh làm cho nhiều gia đình chọn nuôi nó trong nhà.\r\n\r\nNgoại hinh nhỏ nhắn, khuôn mặt nhỏ, tai vểnh cao và đuôi dài, bộ lông ngắn, sọc vằn đen cùng chữ M trên trán làm nên thương hiệu giống mèo mướp này. Loài mèo này thích tắm nắng, liếm lông, ăn vụng và chải chuốt, ngủ nhiều nhưng có tài leo trèo, nhảy nhót, năng động nên được nhiều bạn trẻ đón chào.", "meo_04.jpg"));
                animals.Add(new Animal("Mèo Xiêm", "Đến từ xứ sở chùa Vàng, mèo Xiêm được xem là giống mèo lông ngắn phương với tính cách gần gũi, dễ nuôi và đôi khi khá thô bạo. Giống mèo này có hai dòng chính gồm :\r\n\r\nDòng truyền thống có thân hình cân đối, mặt to tròn và giống mèo vàng hay mèo mướp.\r\n\r\nDòng hiện đại có thân hình mảnh khảnh, thon gọn, lông ngắn và dày có màu socola hay xám, mặt nhiều góc cạnh.", "meo_05.jpg"));
            }
            else if(a.AFid == 3)
            {
                animals.Add(new Animal("Rùa Ba Tư", "", ""));
            }
            else if (a.AFid == 4)
            {
                animals.Add(new Animal("Chim", "", ""));
            }
            InitializeComponent();
            listanimal.ItemsSource = animals;
        }

        private void listanimal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}