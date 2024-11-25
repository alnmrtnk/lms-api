using lms_api.Application.Books.Models;
using lms_api.Application.Borrows.Models;
using lms_api.Application.Reservations.Models;
using lms_api.Application.Users.Models;
using lms_api.Constants;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Hosting;
using Npgsql.Internal.Postgres;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Formats.Tar;
using System.IO.Pipelines;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading;
using System.Xml.Linq;

namespace lms_api.Infrastructure
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
    new Book
    {
        Id = 1,
        Title = "The Great Gatsby",
        Author = "F. Scott Fitzgerald",
        PublishedDate = new DateTime(1925, 4, 10),
        ISBN = " 9781645173519",
        CopiesAvailable = 5,
        Genre = GenreConstants.Genres[0],
        Language = "English",
        Description = @"The Great Gatsby by F. Scott Fitzgerald, set in the 1920s Jazz Age, explores themes of wealth, ambition, love, and the American Dream. Narrated by Nick Carraway, it tells the story of his enigmatic neighbor, Jay Gatsby, who throws lavish parties in pursuit of his lost love, Daisy Buchanan. Daisy, now married to the unfaithful Tom Buchanan, becomes the center of Gatsby's dream to reclaim the past. As Nick witnesses the collision of love, greed, and deceit, the novel reveals the moral decay behind the glitz of the wealthy elite, culminating in tragedy.Fitzgerald's timeless prose captures the illusion and disillusionment of chasing the American Dream.", 
        ImageURL = "https://m.media-amazon.com/images/I/81QuEGw8VPL.jpg"
    },
            new Book
            {
                Id = 2,
                Title = "Don Quixote",
                Author = "Miguel de Cervantes",
                PublishedDate = new DateTime(1605, 1, 16),
                ISBN = "9781509844760",
                CopiesAvailable = 4,
                Genre = GenreConstants.Genres[0],
                Language = "English",
                Description = @"Don Quixote, written by Miguel de Cervantes and published in two parts (1605 and 1615), is a landmark of Western literature and one of the first modern novels. The story follows Alonso Quixano, a middle-aged Spanish gentleman who becomes obsessed with tales of chivalry and reinvents himself as Don Quixote de la Mancha, a knight-errant determined to revive the ideals of knighthood in a world that has moved on. Accompanied by his loyal but skeptical squire, Sancho Panza, Don Quixote embarks on a series of misadventures, mistaking windmills for giants, inns for castles, and ordinary people for figures from his romanticized imagination.His delusions lead to humorous and poignant encounters that reflect the clash between idealism and reality. The novel is a rich exploration of themes such as the nature of reality, the power of imagination, and the tension between tradition and modernity.With its mix of humor, social commentary, and profound insight into human nature, Don Quixote remains a timeless masterpiece.",
                ImageURL = "https://m.media-amazon.com/images/I/61yifvabpVL._AC_UF1000,1000_QL80_.jpg"
            },
            new Book
            {
                Id = 3,
                Title = "Les Misérables",
                Author = "Victor Hugo",
                PublishedDate = new DateTime(1862, 4, 3),
                ISBN = " 9782266296144",
                CopiesAvailable = 3,
                Genre = GenreConstants.Genres[1],
                Language = "French",
                Description = @"Les Misérables, written by Victor Hugo and published in 1862, is an epic tale of love, justice, redemption, and the human struggle for freedom set against the backdrop of early 19th-century France. The novel follows the journey of Jean Valjean, a man imprisoned for stealing bread, who emerges from 19 years of hard labor seeking redemption and a new life. Valjean's path intertwines with a host of characters, including the relentless Inspector Javert, who pursues him for breaking parole; Fantine, a destitute woman whose tragic fate leaves her daughter, Cosette, in Valjean’s care; and revolutionary students fighting for justice during the June Rebellion in Paris. Hugo weaves personal struggles with broader social and political themes, exploring poverty, inequality, love, and the capacity for moral transformation.A story of suffering and hope, Les Misérables is celebrated for its deep emotional resonance and sweeping portrayal of the human condition.",
                ImageURL = " https://wordsworth-editions.com/wp-content/uploads/2024/02/9781853260858.jpg "
            },
            new Book
            {
                Id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                PublishedDate = new DateTime(1813, 1, 28),
                ISBN = "9781840221930",
                CopiesAvailable = 7,
                Genre = GenreConstants.Genres[2],
                Language = "English",
                Description = @"Pride and Prejudice by Jane Austen, published in 1813, is a beloved classic of English literature that explores themes of love, class, and personal growth. The story follows Elizabeth Bennet, an intelligent and spirited young woman, as she navigates societal expectations and family pressures in Regency-era England. Elizabeth’s life becomes entangled with the wealthy and enigmatic Mr.Darcy, whose initial arrogance and pride clash with her quick wit and strong will.Through a series of misunderstandings, personal revelations, and moments of self-reflection, Elizabeth and Darcy must confront their own prejudices and misconceptions about each other. Austen’s sharp social commentary and masterful character development make Pride and Prejudice a timeless tale of love, self-discovery, and the complexities of human relationships.",
                ImageURL = "https://m.media-amazon.com/images/I/812wzoJvRLL._AC_UF1000,1000_QL80_.jpg"
            },
            new Book
            {
                Id = 5,
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling",
                PublishedDate = new DateTime(1997, 6, 26),
                ISBN = "9781408845646",
                CopiesAvailable = 10,
                Genre = GenreConstants.Genres[3],
                Language = "English",
                Description = @"Harry Potter and the Sorcerer’s Stone by J.K. Rowling, first published in 1997, is the magical beginning of the beloved Harry Potter series. The story follows Harry, an orphaned boy who learns on his eleventh birthday that he is a wizard and has been accepted to Hogwarts School of Witchcraft and Wizardry.
        At Hogwarts,
                Harry makes lifelong friends like Ron Weasley and Hermione Granger,
                discovers his connection to the dark wizard Voldemort,
                and uncovers the truth about his parents’ mysterious deaths.As he learns about the magical world,
                Harry faces challenges that reveal his courage,
                loyalty,
                and destiny.
        Centered on themes of friendship,
                bravery,
                and the power of love,
                Harry Potter and the Sorcerer’s Stone introduces readers to a richly imagined world that has captivated audiences of all ages.",
                ImageURL = "https://m.media-amazon.com/images/I/81q77Q39nEL._AC_UF1000,1000_QL80_.jpg"
            },
        new Book
        {
            Id = 6,
            Title = "The Catcher in the Rye",
            Author = "J.D. Salinger",
            PublishedDate = new DateTime(1951, 7, 16),
            ISBN = "9780316769488",
            CopiesAvailable = 6,
            Genre = GenreConstants.Genres[0],
            Language = "English",
            Description = @"The Catcher in the Rye by J.D. Salinger, published in 1951, is a classic coming-of-age novel that captures the struggles of teenage alienation and self-discovery. The story is narrated by Holden Caulfield, a disenchanted and rebellious 16-year-old who has been expelled from his boarding school.
        As Holden wanders through New York City,
            he grapples with his disdain for the phoniness of the adult world while longing for genuine connections.His journey is marked by poignant reflections,
            encounters with strangers,
            and a deep bond with his younger sister,
            Phoebe,
            who represents the innocence he wishes to protect.
        With its raw,
            honest voice and exploration of identity,
            belonging,
            and mental health,
            The Catcher in the Rye remains a powerful and controversial portrayal of adolescent angst.",
                ImageURL = "https://m.media-amazon.com/images/I/8125BDk3l9L.jpg"
        },
            new Book
            {
                Id = 7,
                Title = "One Hundred Years of Solitude",
                Author = "Gabriel García Márquez",
                PublishedDate = new DateTime(1967, 5, 30),
                ISBN = "9780141184999",
                CopiesAvailable = 4,
                Genre = GenreConstants.Genres[0],
                Language = "Spanish",
                Description = @" One Hundred Years of Solitude by Gabriel García Márquez, first published in 1967, is a landmark of world literature and a masterpiece of magical realism. The novel chronicles the rise and fall of the Buendía family over seven generations in the fictional town of Macondo.
        Blending the mundane with the extraordinary,
                the story weaves a rich tapestry of love,
                ambition,
                war,
                and fate as it follows the family’s triumphs and tragedies.Time feels cyclical,
                and history seems destined to repeat itself as the Buendías grapple with isolation,
                secrets,
                and the weight of their past.
        With its lush prose,
                mythical elements,
                and profound exploration of themes like memory,
                identity,
                and the passage of time,
                One Hundred Years of Solitude captures the complexity of human experience and the enduring legacy of family and culture.",
                ImageURL = "https://dwcp78yw3i6ob.cloudfront.net/wp-content/uploads/2016/12/12162813/100_Years_First_Ed_Hi_Res-768x1153.jpg"
            },
            new Book
            {
                Id = 8,
                Title = "The Little Prince",
                Author = "Antoine de Saint-Exupéry",
                PublishedDate = new DateTime(1943, 4, 6),
                ISBN = "9781853261589",
                CopiesAvailable = 8,
                Genre = GenreConstants.Genres[0],
                Language = "French",
                Description = @" The Little Prince by Antoine de Saint-Exupéry, first published in 1943, is a timeless novella that blends a magical story with profound life lessons. It tells the tale of a pilot stranded in the Sahara Desert who meets a young prince from another planet.
        Through the prince’s stories of his travels to different worlds and the characters he meets,
                including a vain man,
                a king,
                and a fox,
                the book explores themes of love,
                friendship,
                imagination,
                and the often - overlooked wisdom of childhood.The prince’s love for his rose and his reflections on human nature invite readers to rediscover what truly matters in life.
        With its enchanting illustrations and heartfelt narrative,
                The Little Prince is a universal fable cherished by readers of all ages. ",
                ImageURL = "https://static.yakaboo.ua/media/catalog/product/c/o/cover_176_116.jpg"
            },
            new Book
            {
                Id = 9,
                Title = "Jane Eyre",
                Author = "Charlotte Brontë",
                PublishedDate = new DateTime(1847, 10, 16),
                ISBN = "9781840227925",
                CopiesAvailable = 5,
                Genre = GenreConstants.Genres[2],
                Language = "English",
                Description = @"Jane Eyre by Charlotte Brontë, published in 1847, is a groundbreaking novel that blends romance, gothic elements, and social commentary. The story follows Jane, an orphaned and independent young woman, as she grows from a mistreated child into a strong and self-reliant adult.

        After enduring hardship at her cruel aunt’s home and a harsh boarding school,
                Jane becomes a governess at Thornfield Hall,
                where she meets the brooding and mysterious Mr.Rochester.As their relationship deepens,
                Jane discovers secrets that test her principles and sense of self - worth.

        A tale of love,
                resilience,
                and self - discovery,
                Jane Eyre challenges societal norms and explores themes of morality,
                independence,
                and the search for belonging.Brontë's vivid storytelling and complex characters make it a timeless classic.",
                ImageURL = "https://m.media-amazon.com/images/M/MV5BYzgxNTI5ZmUtMDMyNy00M2MyLTllN2YtODk3ODE0Y2JkMDVlXkEyXkFqcGc@._V1_.jpg"
            },
            new Book
            {
                Id = 10,
                Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
                Author = "C.S. Lewis",
                PublishedDate = new DateTime(1950, 10, 16),
                ISBN = "9780064471046",
                CopiesAvailable = 9,
                Genre = GenreConstants.Genres[3],
                Language = "English",
                Description = @"The Lion, the Witch and the Wardrobe by C.S. Lewis, first published in 1950, is the first book in The Chronicles of Narnia series. The story follows four siblings—Peter, Susan, Edmund, and Lucy—who are sent to the countryside during World War II. While exploring an old wardrobe in a mysterious house, Lucy stumbles upon a magical land called Narnia, where she meets a faun named Mr. Tumnus.
        Narnia is ruled by the White Witch,
                who has cast a spell that makes it always winter but never Christmas.The children join forces with Aslan,
                the noble lion and true king of Narnia,
                to defeat the Witch and restore peace to the land.
        A captivating blend of fantasy,
                adventure,
                and allegory,
                The Lion,
                the Witch and the Wardrobe explores themes of good vs.evil,
                sacrifice,
                and redemption,
                making it a beloved story for readers of all ages.",
                ImageURL = "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_FMjpg_UX1000_.jpg"
            },
            new Book
            {
                Id = 11,
                Title = "The Alchemist",
                Author = "Paulo Coelho",
                PublishedDate = new DateTime(1988, 11, 10),
                ISBN = "9780007155668",
                CopiesAvailable = 7,
                Genre = GenreConstants.Genres[0],
                Language = "Spanish",
                Description = @" The Alchemist by Paulo Coelho, first published in 1988, is an inspiring allegorical novel about pursuing one’s dreams and finding one’s true purpose. The story follows Santiago, a shepherd boy from Spain, who dreams of discovering a treasure hidden near the Egyptian pyramids.
        Encouraged by a mysterious king,
                Santiago embarks on a journey that takes him across the desert,
                encountering a series of mentors,
                including a crystal merchant,
                an Englishman seeking alchemy,
                and the wise alchemist himself.Along the way,
                Santiago learns to trust the omens of the universe and discovers that the real treasure lies within.
        A timeless tale of self - discovery and spiritual growth,
                The Alchemist resonates with readers through its message about following one’s heart and embracing the journey of life.",
                ImageURL = "https://www.britishbook.ua/upload/resize_cache/iblock/7ef/q4vxhbhlj7xq6hl9rpvggjad4o3nvti2/293_450_174b5ed2089e1946312e2a80dcd26f146/kniga_the_alchemist.jpeg"
            },
            new Book
            {
                Id = 12,
                Title = "The Divine Comedy",
                Author = "Dante Alighieri",
                PublishedDate = new DateTime(1320, 1, 1),
                ISBN = "9781840221664",
                CopiesAvailable = 3,
                Genre = GenreConstants.Genres[0],
                Language = "English",
                Description = @"The Divine Comedy by Dante Alighieri, written in the early 14th century, is an epic poem that stands as a cornerstone of world literature. The narrative follows Dante himself as he embarks on a journey through the realms of the afterlife: Inferno (Hell), Purgatorio (Purgatory), and Paradiso (Paradise). Guided first by the Roman poet Virgil and later by his beloved Beatrice, Dante seeks spiritual enlightenment and salvation.
        Each part of the journey represents a deeper exploration of human sin,
                redemption,
                and divine grace.The vivid imagery and allegorical nature of the poem offer profound insights into morality,
                justice,
                and the human condition, while its richly imagined settings and characters bring Dante’s vision of the afterlife to life.
        A masterpiece of Italian literature,
                The Divine Comedy combines philosophical depth,
                theological reflection,
                and poetic brilliance,
                making it a timeless exploration of the soul’s journey toward God.",
                ImageURL = "https://m.media-amazon.com/images/I/51i-9SGWr-L._AC_UF1000,1000_QL80_.jpg"
            },
            new Book
            {
                Id = 13,
                Title = "Dracula",
                Author = "Bram Stoker",
                PublishedDate = new DateTime(1897, 5, 26),
                ISBN = "9781784871611",
                CopiesAvailable = 4,
                Genre = GenreConstants.Genres[4],
                Language = "English",
                Description = @" Dracula by Bram Stoker, first published in 1897, is a gothic horror classic that introduced the legendary vampire Count Dracula to the world. The story is told through journal entries, letters, and newspaper clippings, creating an immersive and suspenseful narrative.
        It begins with Jonathan Harker,
                a young solicitor,
                traveling to Transylvania to assist Count Dracula with a real estate purchase in England.Harker soon discovers Dracula’s sinister nature and his supernatural powers.As Dracula arrives in England,
                spreading terror and preying on victims,
                a group led by Professor Abraham Van Helsing bands together to stop him.
        Exploring themes of fear,
                desire,
                and the clash between modernity and ancient evil,
                Dracula is a chilling tale of suspense,
                horror,
                and heroism that has profoundly shaped the vampire mythos in popular culture. ",
                ImageURL = "https://www.politeianet.gr/components/com_virtuemart/shop_image/product/1D0DDB608D01D76E19AC5C1AF6062183.jpg"
            },
            new Book
            {
                Id = 14,
                Title = "Inferno",
                Author = "Dan Brown",
                PublishedDate = new DateTime(2013, 5, 14),
                ISBN = "9781400079155",
                CopiesAvailable = 5,
                Genre = GenreConstants.Genres[4],
                Language = "English",
                Description = @"Inferno by Dan Brown, published in 2013, is a gripping thriller that blends history, art, and science with a fast-paced narrative. The story follows Robert Langdon, a Harvard symbologist, who wakes up in a hospital in Florence with no memory of the past two days. He quickly becomes embroiled in a dangerous mystery tied to Dante Alighieri’s The Divine Comedy.
        Langdon teams up with Dr.Sienna Brooks to uncover the meaning behind a cryptic trail of clues left by a brilliant but disturbed geneticist.As they race through iconic landmarks in Florence,
                Venice,
                and Istanbul,
                they discover a chilling plot linked to overpopulation and a deadly bioengineered virus.
        With its mix of historical intrigue and modern ethical dilemmas,
                Inferno explores themes of humanity’s survival and the consequences of unchecked scientific ambition,
                delivering an intense and thought - provoking adventure.",
                ImageURL = "https://m.media-amazon.com/images/I/81z5+6TY94L.jpg"
            },
            new Book
            {
                Id = 15,
                Title = "The Hunchback of Notre-Dame",
                Author = "Victor Hugo",
                PublishedDate = new DateTime(1831, 1, 15),
                ISBN = "9781853260681",
                CopiesAvailable = 5,
                Genre = GenreConstants.Genres[3],
                Language = "French",
                Description = @" The Hunchback of Notre-Dame by Victor Hugo, published in 1831, is a powerful tale of love, tragedy, and social injustice set in 15th-century Paris. At the heart of the story is Quasimodo, the deformed and kind-hearted bell ringer of Notre Dame Cathedral, who lives a life of isolation but finds solace in his devotion to the cathedral.
        Quasimodo’s life changes when he meets Esmeralda,
                a beautiful and compassionate Romani dancer.Their lives become intertwined with those of Claude Frollo,
                the cathedral’s sinister archdeacon,
                and Phoebus,
                a charming soldier.As love,
                jealousy,
                and obsession collide,
                the story unfolds against the backdrop of Parisian society and the majestic cathedral itself.
        With its vivid characters and exploration of themes like human cruelty,
                redemption,
                and the sanctity of love,
                The Hunchback of Notre - Dame is a timeless masterpiece and a celebration of resilience in the face of adversity. ",
                ImageURL = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1388342667i/30597.jpg"
            },
            new Book
            {
                Id = 16,
                Title = "The Kite Runner",
                Author = "Khaled Hosseini",
                PublishedDate = new DateTime(2003, 5, 29),
                ISBN = "9781526604736",
                CopiesAvailable = 6,
                Genre = GenreConstants.Genres[1],
                Language = "English",
                Description = @" The Kite Runner by Khaled Hosseini, first published in 2003, is a poignant and powerful novel about friendship, betrayal, redemption, and the bonds that shape us. Set against the backdrop of Afghanistan’s tumultuous history, the story follows Amir, a privileged young boy, and Hassan, his loyal servant and closest friend.
        Their friendship is shattered by a devastating betrayal,
                and Amir flees to America with his father as political turmoil engulfs their homeland.Years later, as an adult,
                Amir returns to a changed Afghanistan to confront his past and seek redemption.
        A deeply moving exploration of guilt,
                forgiveness,
                and the lasting impact of childhood choices,
                The Kite Runner is celebrated for its vivid storytelling and emotional depth,
                offering a profound glimpse into the human experience and the complexities of love and loyalty.",
                ImageURL = "https://m.media-amazon.com/images/I/81CA-WqU+lL.jpg"
            },
        new Book
        {
            Id = 17,
            Title = "Life of Pi",
            Author = "Yann Martel",
            PublishedDate = new DateTime(2001, 9, 11),
            ISBN = "9781786894243",
            CopiesAvailable = 6,
            Genre = GenreConstants.Genres[0],
            Language = "English",
            Description = @" Life of Pi by Yann Martel, published in 2001, is a compelling tale of survival, faith, and the power of storytelling. The novel follows Piscine Pi Patel, a sixteen-year-old boy from India, whose family owns a zoo. When their ship sinks during a journey to Canada, Pi finds himself stranded on a lifeboat in the Pacific Ocean with an unlikely companion: a Bengal tiger named Richard Parker.
        Over 227 days at sea,
            Pi must use his ingenuity,
            faith,
            and determination to coexist with the tiger and survive the relentless challenges of nature.As Pi recounts his incredible journey,
            he blurs the line between reality and imagination,
            leaving readers to ponder the meaning of truth and belief.
        Life of Pi is a beautifully crafted novel that explores themes of spirituality,
            resilience,
            and the human need for stories to make sense of the world.",
                ImageURL = "https://m.media-amazon.com/images/I/71bRXABY8HL.jpg"
        },
            new Book
            {
                Id = 18,
                Title = "The Stranger",
                Author = "Albert Camus",
                PublishedDate = new DateTime(1942, 1, 1),
                ISBN = "9780679720201",
                CopiesAvailable = 5,
                Genre = GenreConstants.Genres[1],
                Language = "French",
                Description = @" The Stranger by Albert Camus, first published in 1942, is a philosophical novel that explores the absurdity of life and the human search for meaning. The story is narrated by Meursault, an emotionally detached and indifferent man living in Algeria. After the death of his mother, Meursault shows little grief and soon becomes involved in a senseless murder of an Arab man.
        As the story unfolds,
                Meursault's trial reveals society's judgment of his lack of conventional emotions and moral values.Through Meursault’s experiences,
                Camus explores themes of existentialism,
                the randomness of existence,
                and the inevitability of death,
                ultimately challenging the notions of meaning,
                morality,
                and personal responsibility.
        The Stranger is a profound exploration of the human condition,
                known for its stark simplicity,
                its portrayal of isolation,
                and its reflection on the absurdity of life.",
                ImageURL = "https://m.media-amazon.com/images/I/81Al7P2ESgL._AC_UF894,1000_QL80_.jpg"
            },
            new Book
            {
                Id = 19,
                Title = "Cien años de soledad",
                Author = "Gabriel García Márquez",
                PublishedDate = new DateTime(1967, 5, 30),
                ISBN = "9788447333820",
                CopiesAvailable = 3,
                Genre = GenreConstants.Genres[0],
                Language = "Spanish",
                Description = @"Cien años de soledad (One Hundred Years of Solitude) by Gabriel García Márquez, first published in 1967, is a landmark novel in Latin American literature and a masterpiece of magical realism. It chronicles the multi-generational story of the Buendía family, beginning with the founding of the fictional town of Macondo in Colombia.

        The novel blends the everyday with the fantastical, as it follows the lives of the Buendías,
                whose personal and collective destinies are marked by cyclical patterns of love,
                ambition,
                tragedy,
                and solitude.The characters experience profound moments of joy,
                despair,
                and mysticism, while the passage of time is portrayed as both linear and circular,
                creating a sense of inevitability.

        Themes of family,
                history,
                memory,
                and the struggle for identity run throughout Cien años de soledad,
                making it a rich,
                complex narrative that explores both personal and collective experiences.The novel’s innovative style and profound insight into human nature have made it one of the most celebrated works of the 20th century.",
                ImageURL = "https://m.media-amazon.com/images/I/91TvVQS7loL._AC_UF1000,1000_QL80_.jpg"
            },
            new Book
            {
                Id = 20,
                Title = "The Picture of Dorian Gray",
                Author = "Oscar Wilde",
                PublishedDate = new DateTime(1890, 7, 20),
                ISBN = "9781784871710",
                CopiesAvailable = 4,
                Genre = GenreConstants.Genres[0],
                Language = "English",
                Description = @"The Picture of Dorian Gray by Oscar Wilde, first published in 1890, is a gothic novel that explores themes of vanity, corruption, and the consequences of a hedonistic lifestyle. The story centers on Dorian Gray, a handsome young man whose portrait is painted by the artist Basil Hallward. Captivated by his own beauty, Dorian wishes that his portrait would age while he remains youthful, allowing him to live a life of indulgence and excess without suffering the physical consequences.
        As Dorian engages in a life of immoral behavior,
                the portrait becomes a mirror of his corrupted soul,
                aging and showing the signs of his sins, while Dorian himself remains outwardly flawless.His descent into vice and depravity is driven by his obsession with pleasure and his disregard for the moral consequences of his actions.
        Wilde's novel delves into the dangers of vanity and the pursuit of beauty at the expense of one's soul,
                offering a thought - provoking critique of superficiality and self - destruction.The Picture of Dorian Gray is known for its exploration of the duality of human nature and its timeless examination of the conflict between appearance and reality.",
                ImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781625587534/the-picture-of-dorian-gray-9781625587534_hr.jpg"
            },
            new Book
            {
                Id = 21,
                Title = "El amor en los tiempos del cólera",
                Author = "Gabriel García Márquez",
                PublishedDate = new DateTime(1985, 9, 5),
                ISBN = "9788497592451",
                CopiesAvailable = 7,
                Genre = GenreConstants.Genres[2],
                Language = "Spanish",
                Description = @" El amor en los tiempos del cólera (Love in the Time of Cholera) by Gabriel García Márquez, published in 1985, is a poignant and passionate novel about love, obsession, and the passage of time. Set in a Caribbean seaport town, it follows the intertwined lives of two characters, Florentino Ariza and Fermina Daza.
        Florentino,
                a young and idealistic man,
                falls in love with Fermina,
                but she marries the wealthy and pragmatic Dr.Juvenal Urbino instead.Despite their separation,
                Florentino remains devoted to Fermina,
                writing her letters and waiting for the chance to rekindle their love.After decades pass,
                and Dr.Urbino dies,
                Florentino seizes the opportunity to declare his love once again,
                beginning a new chapter of their relationship.
        Through themes of unrequited love,
                aging,
                and the resilience of the human heart,
                El amor en los tiempos del cólera is a moving exploration of the complexities of love across a lifetime.García Márquez’s masterful storytelling captures the beauty and absurdity of love,
                making it a timeless reflection on the endurance of the heart’s desires.",
                ImageURL = "https://hombredelamancha.com/cdn/shop/products/portada_el-amor-en-los-tiempos-del-colera-2015_gabriel-garcia-marquez_201506261929.jpg?v=1657744026"
            },
            new Book
            {
                Id = 22,
                Title = "Wuthering Heights",
                Author = "Emily Brontë",
                PublishedDate = new DateTime(1847, 12, 1),
                ISBN = "9780141439556",
                CopiesAvailable = 5,
                Genre = GenreConstants.Genres[2],
                Language = "English",
                Description = @"Wuthering Heights by Emily Brontë, first published in 1847, is a dark and passionate gothic novel that explores intense emotions, obsessive love, and revenge. Set on the remote Yorkshire moors, the story revolves around the tempestuous relationship between Heathcliff, a brooding and mysterious orphan, and Catherine Earnshaw, the headstrong daughter of the Earnshaw family.

        Their deep,
                destructive love becomes a source of torment for themselves and those around them.Heathcliff,
                after being cruelly mistreated and separated from Catherine,
                returns to Wuthering Heights as a wealthy man,
                determined to exact revenge on those who wronged him.The novel traces the cycles of passion,
                betrayal,
                and vengeance across generations,
                with the haunting specter of love’s destructive power ever - present.

        Wuthering Heights is celebrated for its exploration of complex characters and its portrayal of love’s darker,
                more obsessive aspects,
                making it one of the most compelling and unconventional works in English literature.",
                ImageURL = "https://cdn.kobo.com/book-images/6a3aa32a-8481-4ff3-b21d-ec582dac192a/1200/1200/False/wuthering-heights-232.jpg"
            },
            new Book
            {
                Id = 23,
                Title = "The Shining",
                Author = "Stephen King",
                PublishedDate = new DateTime(1977, 1, 28),
                ISBN = "9781444720723",
                CopiesAvailable = 6,
                Genre = GenreConstants.Genres[4],
                Language = "English",
                Description = @"The Shining by Stephen King, first published in 1977, is a chilling psychological horror novel set in the isolated Overlook Hotel, nestled in the Colorado mountains. The story follows Jack Torrance, an aspiring writer and recovering alcoholic who takes a job as the hotel’s winter caretaker, bringing his wife Wendy and young son Danny with him.
        Danny possesses a psychic ability known as the shining, which allows him to see the hotel's terrifying past and its supernatural inhabitants. As the harsh winter sets in and the hotel becomes more oppressive, Jack begins to unravel mentally, influenced by the malevolent forces within the hotel, while Danny’s powers grow stronger.
        With themes of isolation,
                madness,
                and the power of evil,
                The Shining is a masterful exploration of psychological horror.King's gripping narrative creates an atmosphere of creeping dread, making it one of his most iconic and terrifying works.",
                ImageURL = "https://m.media-amazon.com/images/I/91U7HNa2NQL.jpg"
            },
        new Book
        {
            Id = 24,
            Title = "Le Petit Nicolas",
            Author = "René Goscinny",
            PublishedDate = new DateTime(1959, 3, 29),
            ISBN = "9782070364237",
            CopiesAvailable = 8,
            Genre = GenreConstants.Genres[1],
            Language = "French",
            Description = @" Le Petit Nicolas (Little Nicholas) by René Goscinny, illustrated by Jean-Jacques Sempé, was first published in 1959 and is a humorous and heartwarming collection of stories narrated by the mischievous young boy, Nicolas. The book follows the everyday adventures of Nicolas and his friends, including his interactions with his family, schoolmates, and teachers.
        Through a series of short,
            funny episodes,
            Nicolas finds himself in a variety of lighthearted yet sometimes chaotic situations,
            all while offering a child’s perspective on the world.The stories are filled with innocence,
            playful misunderstandings,
            and a sense of adventure,
            all captured with a gentle,
            satirical humor that appeals to readers of all ages.
        Le Petit Nicolas is beloved for its charm,
            witty dialogues,
            and timeless illustrations,
            making it a classic of French children's literature. Its lighthearted exploration of childhood and its unique characters continue to captivate readers around the world.",
                ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTymS4P5nVVJDZySXx1ID0I8yYc0J4IjeEasQ&s"
        },
            new Book
            {
                Id = 25,
                Title = "The Hunger Games",
                Author = "Suzanne Collins",
                PublishedDate = new DateTime(2008, 9, 14),
                ISBN = "9781407132082",
                CopiesAvailable = 10,
                Genre = GenreConstants.Genres[3],
                Language = "English",
                Description = @"The Hunger Games by Suzanne Collins, first published in 2008, is a dystopian science fiction novel set in a future version of North America, where the nation of Panem is divided into 12 districts, each controlled by the Capitol. Every year, the Capitol selects one boy and one girl from each district to participate in the Hunger Games, a televised battle to the death in an arena.
        The story follows Katniss Everdeen,
                a 16 - year - old girl from District 12,
                who volunteers to take her younger sister’s place in the Games.Alongside her fellow tribute,
                Peeta Mellark,
                Katniss must navigate the deadly competition,
                form alliances,
                and use her skills to survive in a world where trust is scarce and danger is constant.
        The Hunger Games explores themes of survival,
                sacrifice,
                and the consequences of violence and oppression.The novel is known for its gripping action,
                moral complexity,
                and its portrayal of a dystopian society where the fight for freedom and dignity is at the heart of the struggle.",
                ImageURL = "https://www.britishbook.ua/upload/resize_cache/iblock/827/zhymrfljjz58bb8gll43yi4okkdejz64/292_448_174b5ed2089e1946312e2a80dcd26f146/kniga_the_hunger_games_book_1.jpg"
            });


modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", PasswordHash = HashPassword("Admin123!"), Email = "admin@library.com", Role = "Admin" },
                new User { Id = 2, Username = "librarian", PasswordHash = HashPassword("Librarian123!"), Email = "librarian@library.com", Role = "Librarian" },
                new User { Id = 3, Username = "reader1", PasswordHash = HashPassword("Reader123!"), Email = "reader1@library.com", Role = "Reader" },
                new User { Id = 4, Username = "reader2", PasswordHash = HashPassword("Reader456!"), Email = "reader2@library.com", Role = "Reader" }
            );

            modelBuilder.Entity<Borrow>().HasData(
                new Borrow { Id = 1, UserId = 3, BookId = 1, BorrowDate = DateTime.UtcNow.AddDays(-10), ReturnDate = DateTime.UtcNow.AddDays(-2) },
                new Borrow { Id = 2, UserId = 4, BookId = 3, BorrowDate = DateTime.UtcNow.AddDays(-5) }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, UserId = 3, BookId = 2, ReservationDate = DateTime.UtcNow.AddDays(-1), ExpirationDate = DateTime.UtcNow.AddHours(24) },
                new Reservation { Id = 2, UserId = 4, BookId = 4, ReservationDate = DateTime.UtcNow.AddHours(-30), ExpirationDate = DateTime.UtcNow.AddHours(18) }
            );
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
