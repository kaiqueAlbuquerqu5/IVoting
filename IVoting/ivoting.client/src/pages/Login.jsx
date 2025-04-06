import { useState } from "react";
import { Mail } from "lucide-react";
import { Card, CardContent, CardDescription, CardFooter, CardHeader, CardTitle } from "@/components/ui/card";
import { Button } from "@/components/ui/button";
import { Input } from "@/components/ui/input";
import { toast } from "@/components/ui/use-toast";
import VotingLogo from "@/components/VotingLogo";
import * as React from "react";

const Login = () => {
    const [email, setEmail] = useState("");
    const [isLoading, setIsLoading] = useState(false);

    const handleSubmit = async (e) => {
        e.preventDefault();

        if (!email || !email.includes('@')) {
            toast({
                title: "Email inválido",
                description: "Por favor, insira um endereço de email válido.",
                variant: "destructive",
            });
            return;
        }

        setIsLoading(true);

        try {
            // Here would be the actual registration logic
            await new Promise(resolve => setTimeout(resolve, 1000));

            toast({
                title: "Sucesso!",
                description: "Verifique seu email para criar sua sala de votação.",
            });

            // Reset form
            setEmail("");
        } catch (error) {
            toast({
                title: "Erro",
                description: "Ocorreu um erro ao processar seu registro. Tente novamente.",
                variant: "destructive",
            });
        } finally {
            setIsLoading(false);
        }
    };

    return (
        <div className="w-screen h-screen flex flex-col items-center justify-center bg-gradient-to-b from-[#f0f4ff] to-white px-4">
            <div className="w-full max-w-md text-center mb-8">
                <VotingLogo className="mx-auto mb-4" />
                <h1 className="text-3xl font-bold text-voting-primary">Voting Helper Hub</h1>
                <p className="text-muted-foreground mt-2">
                    Crie salas de votação e compartilhe com seus participantes
                </p>
            </div>

            <Card className="w-full max-w-md shadow-xl border border-gray-200">
                <CardHeader>
                    <CardTitle className="text-xl text-center">Criar uma Sala de Votação</CardTitle>
                    <CardDescription className="text-center text-sm text-gray-500">
                        Insira seu email para começar a criar sua sala
                    </CardDescription>
                </CardHeader>
                <CardContent>
                    <form onSubmit={handleSubmit} className="space-y-4">
                        <div className="relative">
                            <Mail className="absolute left-3 top-1/2 -translate-y-1/2 text-gray-400 h-5 w-5" />
                            <Input
                                type="email"
                                placeholder="seu@email.com"
                                className="pl-10"
                                value={email}
                                onChange={(e) => setEmail(e.target.value)}
                                required
                            />
                        </div>
                        <Button
                            type="submit"
                            className="w-full bg-voting-primary hover:bg-voting-secondary transition-colors"
                            disabled={isLoading}
                        >
                            {isLoading ? "Processando..." : "Criar Sala de Votação"}
                        </Button>
                    </form>
                </CardContent>
                <CardFooter className="flex justify-center text-sm text-gray-500">
                    Ao criar uma sala, você concorda com os nossos termos de uso
                </CardFooter>
            </Card>
        </div>
    );
};

export default Login;