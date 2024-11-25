using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class Add_New_Books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ISBN", "ImageURL", "Language" },
                values: new object[] { "The Great Gatsby by F. Scott Fitzgerald, set in the 1920s Jazz Age, explores themes of wealth, ambition, love, and the American Dream. Narrated by Nick Carraway, it tells the story of his enigmatic neighbor, Jay Gatsby, who throws lavish parties in pursuit of his lost love, Daisy Buchanan. Daisy, now married to the unfaithful Tom Buchanan, becomes the center of Gatsby's dream to reclaim the past. As Nick witnesses the collision of love, greed, and deceit, the novel reveals the moral decay behind the glitz of the wealthy elite, culminating in tragedy.Fitzgerald's timeless prose captures the illusion and disillusionment of chasing the American Dream.", " 9781645173519", "https://m.media-amazon.com/images/I/81QuEGw8VPL.jpg", "English" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CopiesAvailable", "Description", "ISBN", "ImageURL", "Language", "PublishedDate", "Title" },
                values: new object[] { "Miguel de Cervantes", 4, "Don Quixote, written by Miguel de Cervantes and published in two parts (1605 and 1615), is a landmark of Western literature and one of the first modern novels. The story follows Alonso Quixano, a middle-aged Spanish gentleman who becomes obsessed with tales of chivalry and reinvents himself as Don Quixote de la Mancha, a knight-errant determined to revive the ideals of knighthood in a world that has moved on. Accompanied by his loyal but skeptical squire, Sancho Panza, Don Quixote embarks on a series of misadventures, mistaking windmills for giants, inns for castles, and ordinary people for figures from his romanticized imagination.His delusions lead to humorous and poignant encounters that reflect the clash between idealism and reality. The novel is a rich exploration of themes such as the nature of reality, the power of imagination, and the tension between tradition and modernity.With its mix of humor, social commentary, and profound insight into human nature, Don Quixote remains a timeless masterpiece.", "9781509844760", "https://m.media-amazon.com/images/I/61yifvabpVL._AC_UF1000,1000_QL80_.jpg", "English", new DateTime(1605, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Don Quixote" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CopiesAvailable", "Description", "Genre", "ISBN", "ImageURL", "Language", "PublishedDate", "Title" },
                values: new object[] { "Victor Hugo", 3, "Les Misérables, written by Victor Hugo and published in 1862, is an epic tale of love, justice, redemption, and the human struggle for freedom set against the backdrop of early 19th-century France. The novel follows the journey of Jean Valjean, a man imprisoned for stealing bread, who emerges from 19 years of hard labor seeking redemption and a new life. Valjean's path intertwines with a host of characters, including the relentless Inspector Javert, who pursues him for breaking parole; Fantine, a destitute woman whose tragic fate leaves her daughter, Cosette, in Valjean’s care; and revolutionary students fighting for justice during the June Rebellion in Paris. Hugo weaves personal struggles with broader social and political themes, exploring poverty, inequality, love, and the capacity for moral transformation.A story of suffering and hope, Les Misérables is celebrated for its deep emotional resonance and sweeping portrayal of the human condition.", "Non-Fiction", " 9782266296144", " https://wordsworth-editions.com/wp-content/uploads/2024/02/9781853260858.jpg ", "French", new DateTime(1862, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Les Misérables" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CopiesAvailable", "Description", "Genre", "ISBN", "ImageURL", "Language", "PublishedDate", "Title" },
                values: new object[] { "Jane Austen", 7, "Pride and Prejudice by Jane Austen, published in 1813, is a beloved classic of English literature that explores themes of love, class, and personal growth. The story follows Elizabeth Bennet, an intelligent and spirited young woman, as she navigates societal expectations and family pressures in Regency-era England. Elizabeth’s life becomes entangled with the wealthy and enigmatic Mr.Darcy, whose initial arrogance and pride clash with her quick wit and strong will.Through a series of misunderstandings, personal revelations, and moments of self-reflection, Elizabeth and Darcy must confront their own prejudices and misconceptions about each other. Austen’s sharp social commentary and masterful character development make Pride and Prejudice a timeless tale of love, self-discovery, and the complexities of human relationships.", "Romance", "9781840221930", "https://m.media-amazon.com/images/I/812wzoJvRLL._AC_UF1000,1000_QL80_.jpg", "English", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Pride and Prejudice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CopiesAvailable", "Description", "Genre", "ISBN", "ImageURL", "Language", "PublishedDate", "Title" },
                values: new object[] { "J.K. Rowling", 10, "Harry Potter and the Sorcerer’s Stone by J.K. Rowling, first published in 1997, is the magical beginning of the beloved Harry Potter series. The story follows Harry, an orphaned boy who learns on his eleventh birthday that he is a wizard and has been accepted to Hogwarts School of Witchcraft and Wizardry.\r\n        At Hogwarts,\r\n                Harry makes lifelong friends like Ron Weasley and Hermione Granger,\r\n                discovers his connection to the dark wizard Voldemort,\r\n                and uncovers the truth about his parents’ mysterious deaths.As he learns about the magical world,\r\n                Harry faces challenges that reveal his courage,\r\n                loyalty,\r\n                and destiny.\r\n        Centered on themes of friendship,\r\n                bravery,\r\n                and the power of love,\r\n                Harry Potter and the Sorcerer’s Stone introduces readers to a richly imagined world that has captivated audiences of all ages.", "Fantasy", "9781408845646", "https://m.media-amazon.com/images/I/81q77Q39nEL._AC_UF1000,1000_QL80_.jpg", "English", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Harry Potter and the Sorcerer's Stone" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CopiesAvailable", "Description", "Genre", "ISBN", "ImageURL", "Language", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 6, "J.D. Salinger", 6, "The Catcher in the Rye by J.D. Salinger, published in 1951, is a classic coming-of-age novel that captures the struggles of teenage alienation and self-discovery. The story is narrated by Holden Caulfield, a disenchanted and rebellious 16-year-old who has been expelled from his boarding school.\r\n        As Holden wanders through New York City,\r\n            he grapples with his disdain for the phoniness of the adult world while longing for genuine connections.His journey is marked by poignant reflections,\r\n            encounters with strangers,\r\n            and a deep bond with his younger sister,\r\n            Phoebe,\r\n            who represents the innocence he wishes to protect.\r\n        With its raw,\r\n            honest voice and exploration of identity,\r\n            belonging,\r\n            and mental health,\r\n            The Catcher in the Rye remains a powerful and controversial portrayal of adolescent angst.", "Fiction", "9780316769488", "https://m.media-amazon.com/images/I/8125BDk3l9L.jpg", "English", new DateTime(1951, 7, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Catcher in the Rye" },
                    { 7, "Gabriel García Márquez", 4, " One Hundred Years of Solitude by Gabriel García Márquez, first published in 1967, is a landmark of world literature and a masterpiece of magical realism. The novel chronicles the rise and fall of the Buendía family over seven generations in the fictional town of Macondo.\r\n        Blending the mundane with the extraordinary,\r\n                the story weaves a rich tapestry of love,\r\n                ambition,\r\n                war,\r\n                and fate as it follows the family’s triumphs and tragedies.Time feels cyclical,\r\n                and history seems destined to repeat itself as the Buendías grapple with isolation,\r\n                secrets,\r\n                and the weight of their past.\r\n        With its lush prose,\r\n                mythical elements,\r\n                and profound exploration of themes like memory,\r\n                identity,\r\n                and the passage of time,\r\n                One Hundred Years of Solitude captures the complexity of human experience and the enduring legacy of family and culture.", "Fiction", "9780141184999", "https://dwcp78yw3i6ob.cloudfront.net/wp-content/uploads/2016/12/12162813/100_Years_First_Ed_Hi_Res-768x1153.jpg", "Spanish", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "One Hundred Years of Solitude" },
                    { 8, "Antoine de Saint-Exupéry", 8, " The Little Prince by Antoine de Saint-Exupéry, first published in 1943, is a timeless novella that blends a magical story with profound life lessons. It tells the tale of a pilot stranded in the Sahara Desert who meets a young prince from another planet.\r\n        Through the prince’s stories of his travels to different worlds and the characters he meets,\r\n                including a vain man,\r\n                a king,\r\n                and a fox,\r\n                the book explores themes of love,\r\n                friendship,\r\n                imagination,\r\n                and the often - overlooked wisdom of childhood.The prince’s love for his rose and his reflections on human nature invite readers to rediscover what truly matters in life.\r\n        With its enchanting illustrations and heartfelt narrative,\r\n                The Little Prince is a universal fable cherished by readers of all ages. ", "Fiction", "9781853261589", "https://static.yakaboo.ua/media/catalog/product/c/o/cover_176_116.jpg", "French", new DateTime(1943, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Little Prince" },
                    { 9, "Charlotte Brontë", 5, "Jane Eyre by Charlotte Brontë, published in 1847, is a groundbreaking novel that blends romance, gothic elements, and social commentary. The story follows Jane, an orphaned and independent young woman, as she grows from a mistreated child into a strong and self-reliant adult.\r\n\r\n        After enduring hardship at her cruel aunt’s home and a harsh boarding school,\r\n                Jane becomes a governess at Thornfield Hall,\r\n                where she meets the brooding and mysterious Mr.Rochester.As their relationship deepens,\r\n                Jane discovers secrets that test her principles and sense of self - worth.\r\n\r\n        A tale of love,\r\n                resilience,\r\n                and self - discovery,\r\n                Jane Eyre challenges societal norms and explores themes of morality,\r\n                independence,\r\n                and the search for belonging.Brontë's vivid storytelling and complex characters make it a timeless classic.", "Romance", "9781840227925", "https://m.media-amazon.com/images/M/MV5BYzgxNTI5ZmUtMDMyNy00M2MyLTllN2YtODk3ODE0Y2JkMDVlXkEyXkFqcGc@._V1_.jpg", "English", new DateTime(1847, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Jane Eyre" },
                    { 10, "C.S. Lewis", 9, "The Lion, the Witch and the Wardrobe by C.S. Lewis, first published in 1950, is the first book in The Chronicles of Narnia series. The story follows four siblings—Peter, Susan, Edmund, and Lucy—who are sent to the countryside during World War II. While exploring an old wardrobe in a mysterious house, Lucy stumbles upon a magical land called Narnia, where she meets a faun named Mr. Tumnus.\r\n        Narnia is ruled by the White Witch,\r\n                who has cast a spell that makes it always winter but never Christmas.The children join forces with Aslan,\r\n                the noble lion and true king of Narnia,\r\n                to defeat the Witch and restore peace to the land.\r\n        A captivating blend of fantasy,\r\n                adventure,\r\n                and allegory,\r\n                The Lion,\r\n                the Witch and the Wardrobe explores themes of good vs.evil,\r\n                sacrifice,\r\n                and redemption,\r\n                making it a beloved story for readers of all ages.", "Fantasy", "9780064471046", "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_FMjpg_UX1000_.jpg", "English", new DateTime(1950, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe" },
                    { 11, "Paulo Coelho", 7, " The Alchemist by Paulo Coelho, first published in 1988, is an inspiring allegorical novel about pursuing one’s dreams and finding one’s true purpose. The story follows Santiago, a shepherd boy from Spain, who dreams of discovering a treasure hidden near the Egyptian pyramids.\r\n        Encouraged by a mysterious king,\r\n                Santiago embarks on a journey that takes him across the desert,\r\n                encountering a series of mentors,\r\n                including a crystal merchant,\r\n                an Englishman seeking alchemy,\r\n                and the wise alchemist himself.Along the way,\r\n                Santiago learns to trust the omens of the universe and discovers that the real treasure lies within.\r\n        A timeless tale of self - discovery and spiritual growth,\r\n                The Alchemist resonates with readers through its message about following one’s heart and embracing the journey of life.", "Fiction", "9780007155668", "https://www.britishbook.ua/upload/resize_cache/iblock/7ef/q4vxhbhlj7xq6hl9rpvggjad4o3nvti2/293_450_174b5ed2089e1946312e2a80dcd26f146/kniga_the_alchemist.jpeg", "Spanish", new DateTime(1988, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Alchemist" },
                    { 12, "Dante Alighieri", 3, "The Divine Comedy by Dante Alighieri, written in the early 14th century, is an epic poem that stands as a cornerstone of world literature. The narrative follows Dante himself as he embarks on a journey through the realms of the afterlife: Inferno (Hell), Purgatorio (Purgatory), and Paradiso (Paradise). Guided first by the Roman poet Virgil and later by his beloved Beatrice, Dante seeks spiritual enlightenment and salvation.\r\n        Each part of the journey represents a deeper exploration of human sin,\r\n                redemption,\r\n                and divine grace.The vivid imagery and allegorical nature of the poem offer profound insights into morality,\r\n                justice,\r\n                and the human condition, while its richly imagined settings and characters bring Dante’s vision of the afterlife to life.\r\n        A masterpiece of Italian literature,\r\n                The Divine Comedy combines philosophical depth,\r\n                theological reflection,\r\n                and poetic brilliance,\r\n                making it a timeless exploration of the soul’s journey toward God.", "Fiction", "9781840221664", "https://m.media-amazon.com/images/I/51i-9SGWr-L._AC_UF1000,1000_QL80_.jpg", "English", new DateTime(1320, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Divine Comedy" },
                    { 13, "Bram Stoker", 4, " Dracula by Bram Stoker, first published in 1897, is a gothic horror classic that introduced the legendary vampire Count Dracula to the world. The story is told through journal entries, letters, and newspaper clippings, creating an immersive and suspenseful narrative.\r\n        It begins with Jonathan Harker,\r\n                a young solicitor,\r\n                traveling to Transylvania to assist Count Dracula with a real estate purchase in England.Harker soon discovers Dracula’s sinister nature and his supernatural powers.As Dracula arrives in England,\r\n                spreading terror and preying on victims,\r\n                a group led by Professor Abraham Van Helsing bands together to stop him.\r\n        Exploring themes of fear,\r\n                desire,\r\n                and the clash between modernity and ancient evil,\r\n                Dracula is a chilling tale of suspense,\r\n                horror,\r\n                and heroism that has profoundly shaped the vampire mythos in popular culture. ", "Mystery", "9781784871611", "https://www.politeianet.gr/components/com_virtuemart/shop_image/product/1D0DDB608D01D76E19AC5C1AF6062183.jpg", "English", new DateTime(1897, 5, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Dracula" },
                    { 14, "Dan Brown", 5, "Inferno by Dan Brown, published in 2013, is a gripping thriller that blends history, art, and science with a fast-paced narrative. The story follows Robert Langdon, a Harvard symbologist, who wakes up in a hospital in Florence with no memory of the past two days. He quickly becomes embroiled in a dangerous mystery tied to Dante Alighieri’s The Divine Comedy.\r\n        Langdon teams up with Dr.Sienna Brooks to uncover the meaning behind a cryptic trail of clues left by a brilliant but disturbed geneticist.As they race through iconic landmarks in Florence,\r\n                Venice,\r\n                and Istanbul,\r\n                they discover a chilling plot linked to overpopulation and a deadly bioengineered virus.\r\n        With its mix of historical intrigue and modern ethical dilemmas,\r\n                Inferno explores themes of humanity’s survival and the consequences of unchecked scientific ambition,\r\n                delivering an intense and thought - provoking adventure.", "Mystery", "9781400079155", "https://m.media-amazon.com/images/I/81z5+6TY94L.jpg", "English", new DateTime(2013, 5, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Inferno" },
                    { 15, "Victor Hugo", 5, " The Hunchback of Notre-Dame by Victor Hugo, published in 1831, is a powerful tale of love, tragedy, and social injustice set in 15th-century Paris. At the heart of the story is Quasimodo, the deformed and kind-hearted bell ringer of Notre Dame Cathedral, who lives a life of isolation but finds solace in his devotion to the cathedral.\r\n        Quasimodo’s life changes when he meets Esmeralda,\r\n                a beautiful and compassionate Romani dancer.Their lives become intertwined with those of Claude Frollo,\r\n                the cathedral’s sinister archdeacon,\r\n                and Phoebus,\r\n                a charming soldier.As love,\r\n                jealousy,\r\n                and obsession collide,\r\n                the story unfolds against the backdrop of Parisian society and the majestic cathedral itself.\r\n        With its vivid characters and exploration of themes like human cruelty,\r\n                redemption,\r\n                and the sanctity of love,\r\n                The Hunchback of Notre - Dame is a timeless masterpiece and a celebration of resilience in the face of adversity. ", "Fantasy", "9781853260681", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1388342667i/30597.jpg", "French", new DateTime(1831, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Hunchback of Notre-Dame" },
                    { 16, "Khaled Hosseini", 6, " The Kite Runner by Khaled Hosseini, first published in 2003, is a poignant and powerful novel about friendship, betrayal, redemption, and the bonds that shape us. Set against the backdrop of Afghanistan’s tumultuous history, the story follows Amir, a privileged young boy, and Hassan, his loyal servant and closest friend.\r\n        Their friendship is shattered by a devastating betrayal,\r\n                and Amir flees to America with his father as political turmoil engulfs their homeland.Years later, as an adult,\r\n                Amir returns to a changed Afghanistan to confront his past and seek redemption.\r\n        A deeply moving exploration of guilt,\r\n                forgiveness,\r\n                and the lasting impact of childhood choices,\r\n                The Kite Runner is celebrated for its vivid storytelling and emotional depth,\r\n                offering a profound glimpse into the human experience and the complexities of love and loyalty.", "Non-Fiction", "9781526604736", "https://m.media-amazon.com/images/I/81CA-WqU+lL.jpg", "English", new DateTime(2003, 5, 29, 0, 0, 0, 0, DateTimeKind.Utc), "The Kite Runner" },
                    { 17, "Yann Martel", 6, " Life of Pi by Yann Martel, published in 2001, is a compelling tale of survival, faith, and the power of storytelling. The novel follows Piscine Pi Patel, a sixteen-year-old boy from India, whose family owns a zoo. When their ship sinks during a journey to Canada, Pi finds himself stranded on a lifeboat in the Pacific Ocean with an unlikely companion: a Bengal tiger named Richard Parker.\r\n        Over 227 days at sea,\r\n            Pi must use his ingenuity,\r\n            faith,\r\n            and determination to coexist with the tiger and survive the relentless challenges of nature.As Pi recounts his incredible journey,\r\n            he blurs the line between reality and imagination,\r\n            leaving readers to ponder the meaning of truth and belief.\r\n        Life of Pi is a beautifully crafted novel that explores themes of spirituality,\r\n            resilience,\r\n            and the human need for stories to make sense of the world.", "Fiction", "9781786894243", "https://m.media-amazon.com/images/I/71bRXABY8HL.jpg", "English", new DateTime(2001, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Life of Pi" },
                    { 18, "Albert Camus", 5, " The Stranger by Albert Camus, first published in 1942, is a philosophical novel that explores the absurdity of life and the human search for meaning. The story is narrated by Meursault, an emotionally detached and indifferent man living in Algeria. After the death of his mother, Meursault shows little grief and soon becomes involved in a senseless murder of an Arab man.\r\n        As the story unfolds,\r\n                Meursault's trial reveals society's judgment of his lack of conventional emotions and moral values.Through Meursault’s experiences,\r\n                Camus explores themes of existentialism,\r\n                the randomness of existence,\r\n                and the inevitability of death,\r\n                ultimately challenging the notions of meaning,\r\n                morality,\r\n                and personal responsibility.\r\n        The Stranger is a profound exploration of the human condition,\r\n                known for its stark simplicity,\r\n                its portrayal of isolation,\r\n                and its reflection on the absurdity of life.", "Non-Fiction", "9780679720201", "https://m.media-amazon.com/images/I/81Al7P2ESgL._AC_UF894,1000_QL80_.jpg", "French", new DateTime(1942, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Stranger" },
                    { 19, "Gabriel García Márquez", 3, "Cien años de soledad (One Hundred Years of Solitude) by Gabriel García Márquez, first published in 1967, is a landmark novel in Latin American literature and a masterpiece of magical realism. It chronicles the multi-generational story of the Buendía family, beginning with the founding of the fictional town of Macondo in Colombia.\r\n\r\n        The novel blends the everyday with the fantastical, as it follows the lives of the Buendías,\r\n                whose personal and collective destinies are marked by cyclical patterns of love,\r\n                ambition,\r\n                tragedy,\r\n                and solitude.The characters experience profound moments of joy,\r\n                despair,\r\n                and mysticism, while the passage of time is portrayed as both linear and circular,\r\n                creating a sense of inevitability.\r\n\r\n        Themes of family,\r\n                history,\r\n                memory,\r\n                and the struggle for identity run throughout Cien años de soledad,\r\n                making it a rich,\r\n                complex narrative that explores both personal and collective experiences.The novel’s innovative style and profound insight into human nature have made it one of the most celebrated works of the 20th century.", "Fiction", "9788447333820", "https://m.media-amazon.com/images/I/91TvVQS7loL._AC_UF1000,1000_QL80_.jpg", "Spanish", new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Cien años de soledad" },
                    { 20, "Oscar Wilde", 4, "The Picture of Dorian Gray by Oscar Wilde, first published in 1890, is a gothic novel that explores themes of vanity, corruption, and the consequences of a hedonistic lifestyle. The story centers on Dorian Gray, a handsome young man whose portrait is painted by the artist Basil Hallward. Captivated by his own beauty, Dorian wishes that his portrait would age while he remains youthful, allowing him to live a life of indulgence and excess without suffering the physical consequences.\r\n        As Dorian engages in a life of immoral behavior,\r\n                the portrait becomes a mirror of his corrupted soul,\r\n                aging and showing the signs of his sins, while Dorian himself remains outwardly flawless.His descent into vice and depravity is driven by his obsession with pleasure and his disregard for the moral consequences of his actions.\r\n        Wilde's novel delves into the dangers of vanity and the pursuit of beauty at the expense of one's soul,\r\n                offering a thought - provoking critique of superficiality and self - destruction.The Picture of Dorian Gray is known for its exploration of the duality of human nature and its timeless examination of the conflict between appearance and reality.", "Fiction", "9781784871710", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781625587534/the-picture-of-dorian-gray-9781625587534_hr.jpg", "English", new DateTime(1890, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray" },
                    { 21, "Gabriel García Márquez", 7, " El amor en los tiempos del cólera (Love in the Time of Cholera) by Gabriel García Márquez, published in 1985, is a poignant and passionate novel about love, obsession, and the passage of time. Set in a Caribbean seaport town, it follows the intertwined lives of two characters, Florentino Ariza and Fermina Daza.\r\n        Florentino,\r\n                a young and idealistic man,\r\n                falls in love with Fermina,\r\n                but she marries the wealthy and pragmatic Dr.Juvenal Urbino instead.Despite their separation,\r\n                Florentino remains devoted to Fermina,\r\n                writing her letters and waiting for the chance to rekindle their love.After decades pass,\r\n                and Dr.Urbino dies,\r\n                Florentino seizes the opportunity to declare his love once again,\r\n                beginning a new chapter of their relationship.\r\n        Through themes of unrequited love,\r\n                aging,\r\n                and the resilience of the human heart,\r\n                El amor en los tiempos del cólera is a moving exploration of the complexities of love across a lifetime.García Márquez’s masterful storytelling captures the beauty and absurdity of love,\r\n                making it a timeless reflection on the endurance of the heart’s desires.", "Romance", "9788497592451", "https://hombredelamancha.com/cdn/shop/products/portada_el-amor-en-los-tiempos-del-colera-2015_gabriel-garcia-marquez_201506261929.jpg?v=1657744026", "Spanish", new DateTime(1985, 9, 5, 0, 0, 0, 0, DateTimeKind.Utc), "El amor en los tiempos del cólera" },
                    { 22, "Emily Brontë", 5, "Wuthering Heights by Emily Brontë, first published in 1847, is a dark and passionate gothic novel that explores intense emotions, obsessive love, and revenge. Set on the remote Yorkshire moors, the story revolves around the tempestuous relationship between Heathcliff, a brooding and mysterious orphan, and Catherine Earnshaw, the headstrong daughter of the Earnshaw family.\r\n\r\n        Their deep,\r\n                destructive love becomes a source of torment for themselves and those around them.Heathcliff,\r\n                after being cruelly mistreated and separated from Catherine,\r\n                returns to Wuthering Heights as a wealthy man,\r\n                determined to exact revenge on those who wronged him.The novel traces the cycles of passion,\r\n                betrayal,\r\n                and vengeance across generations,\r\n                with the haunting specter of love’s destructive power ever - present.\r\n\r\n        Wuthering Heights is celebrated for its exploration of complex characters and its portrayal of love’s darker,\r\n                more obsessive aspects,\r\n                making it one of the most compelling and unconventional works in English literature.", "Romance", "9780141439556", "https://cdn.kobo.com/book-images/6a3aa32a-8481-4ff3-b21d-ec582dac192a/1200/1200/False/wuthering-heights-232.jpg", "English", new DateTime(1847, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wuthering Heights" },
                    { 23, "Stephen King", 6, "The Shining by Stephen King, first published in 1977, is a chilling psychological horror novel set in the isolated Overlook Hotel, nestled in the Colorado mountains. The story follows Jack Torrance, an aspiring writer and recovering alcoholic who takes a job as the hotel’s winter caretaker, bringing his wife Wendy and young son Danny with him.\r\n        Danny possesses a psychic ability known as the shining, which allows him to see the hotel's terrifying past and its supernatural inhabitants. As the harsh winter sets in and the hotel becomes more oppressive, Jack begins to unravel mentally, influenced by the malevolent forces within the hotel, while Danny’s powers grow stronger.\r\n        With themes of isolation,\r\n                madness,\r\n                and the power of evil,\r\n                The Shining is a masterful exploration of psychological horror.King's gripping narrative creates an atmosphere of creeping dread, making it one of his most iconic and terrifying works.", "Mystery", "9781444720723", "https://m.media-amazon.com/images/I/91U7HNa2NQL.jpg", "English", new DateTime(1977, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "The Shining" },
                    { 24, "René Goscinny", 8, " Le Petit Nicolas (Little Nicholas) by René Goscinny, illustrated by Jean-Jacques Sempé, was first published in 1959 and is a humorous and heartwarming collection of stories narrated by the mischievous young boy, Nicolas. The book follows the everyday adventures of Nicolas and his friends, including his interactions with his family, schoolmates, and teachers.\r\n        Through a series of short,\r\n            funny episodes,\r\n            Nicolas finds himself in a variety of lighthearted yet sometimes chaotic situations,\r\n            all while offering a child’s perspective on the world.The stories are filled with innocence,\r\n            playful misunderstandings,\r\n            and a sense of adventure,\r\n            all captured with a gentle,\r\n            satirical humor that appeals to readers of all ages.\r\n        Le Petit Nicolas is beloved for its charm,\r\n            witty dialogues,\r\n            and timeless illustrations,\r\n            making it a classic of French children's literature. Its lighthearted exploration of childhood and its unique characters continue to captivate readers around the world.", "Non-Fiction", "9782070364237", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTymS4P5nVVJDZySXx1ID0I8yYc0J4IjeEasQ&s", "French", new DateTime(1959, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Le Petit Nicolas" },
                    { 25, "Suzanne Collins", 10, "The Hunger Games by Suzanne Collins, first published in 2008, is a dystopian science fiction novel set in a future version of North America, where the nation of Panem is divided into 12 districts, each controlled by the Capitol. Every year, the Capitol selects one boy and one girl from each district to participate in the Hunger Games, a televised battle to the death in an arena.\r\n        The story follows Katniss Everdeen,\r\n                a 16 - year - old girl from District 12,\r\n                who volunteers to take her younger sister’s place in the Games.Alongside her fellow tribute,\r\n                Peeta Mellark,\r\n                Katniss must navigate the deadly competition,\r\n                form alliances,\r\n                and use her skills to survive in a world where trust is scarce and danger is constant.\r\n        The Hunger Games explores themes of survival,\r\n                sacrifice,\r\n                and the consequences of violence and oppression.The novel is known for its gripping action,\r\n                moral complexity,\r\n                and its portrayal of a dystopian society where the fight for freedom and dignity is at the heart of the struggle.", "Fantasy", "9781407132082", "https://www.britishbook.ua/upload/resize_cache/iblock/827/zhymrfljjz58bb8gll43yi4okkdejz64/292_448_174b5ed2089e1946312e2a80dcd26f146/kniga_the_hunger_games_book_1.jpg", "English", new DateTime(2008, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Hunger Games" }
                });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 15, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(266), new DateTime(2024, 11, 23, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 20, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 26, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 11, 24, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 3, 58, 58, DateTimeKind.Utc).AddTicks(343), new DateTime(2024, 11, 24, 13, 3, 58, 58, DateTimeKind.Utc).AddTicks(342) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ISBN",
                value: "9780743273565");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CopiesAvailable", "ISBN", "PublishedDate", "Title" },
                values: new object[] { "Harper Lee", 3, "9780061120084", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Utc), "To Kill a Mockingbird" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CopiesAvailable", "Genre", "ISBN", "PublishedDate", "Title" },
                values: new object[] { "George Orwell", 4, "Romance", "9780451524935", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc), "1984" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CopiesAvailable", "Genre", "ISBN", "PublishedDate", "Title" },
                values: new object[] { "J.R.R. Tolkien", 6, "Fantasy", "9780547928227", new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Hobbit" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CopiesAvailable", "Genre", "ISBN", "PublishedDate", "Title" },
                values: new object[] { "Dan Brown", 2, "Mystery", "9780307474278", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code" });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 9, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 11, 17, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 14, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 20, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4866), new DateTime(2024, 11, 18, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 20, 7, 50, 30, 113, DateTimeKind.Utc).AddTicks(4869), new DateTime(2024, 11, 18, 7, 50, 30, 113, DateTimeKind.Utc).AddTicks(4868) });
        }
    }
}
