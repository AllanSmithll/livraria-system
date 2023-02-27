export default interface LivrosModel {
        id: string;
        title: string;
        subtitle: string | null;
        resume: string | null;
        gender: string[] | string;
        pages: number;
        year: number;
        edition: number | null;
        nameAuthor: string[] | string;
        namePublisher: string;
}