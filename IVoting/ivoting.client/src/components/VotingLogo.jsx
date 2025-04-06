import React from "react";
import { Vote } from "lucide-react";
import { cn } from "@/lib/utils"; // Certifique-se que esse arquivo existe, senão eu posso te passar ele

function VotingLogo({ className }) {
    return (
        <div className={cn("flex items-center justify-center w-16 h-16 rounded-full bg-voting-primary text-white", className)}>
            <Vote className="h-8 w-8" />
        </div>
    );
}

export default VotingLogo;
